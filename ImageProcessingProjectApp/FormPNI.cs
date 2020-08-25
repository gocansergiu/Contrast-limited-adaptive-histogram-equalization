using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessingProjectApp
{
    public class Clahe
    {
      
        int grayLevels = 256;
        float binXsize, binYsize;
        float clipLimit = 2.5F; //default contrast limiting parameter
     
        int[,][] iHists, LUTs;
        Bitmap image, result;




        public Clahe(float cLimit, Bitmap image)
        {

           this.image = image;
            this.clipLimit = cLimit;
        

            binXsize = this.image.Width / 8;
            binYsize = this.image.Height / 8;
        }

        void computeHistogram()
        {
            iHists = new int[8, 8][];
            int x0, x1, y0, y1;

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    x0 = (int)Math.Round(i * binXsize);
                    y0 = (int)Math.Round(j * binYsize);
                    x1 = (int)Math.Round((i + 1) * binXsize);
                    y1 = (int)Math.Round((j + 1) * binYsize);
                    iHists[i, j] = computeHistogram(x0, x1, y0, y1);
                }

        }

        //Histogram Computation 
        int[] computeHistogram(int x0, int x1, int y0, int y1)
        {
            int[] iHisto = new int[256];
            Color c; // better when working with bitmap
            int gScale;
            // standard histogram
            for (int x = x0; x < x1; x++)
            {
                for (int y = y0; y < y1; y++)
                {
                    // Get pixel color 
                    c = image.GetPixel(x, y);
                    // convert c to grayscale
                    gScale = (int)((c.R + c.G + c.B) / 3);
               
                    iHisto[gScale] ++;
                }
            }
            return iHisto;
        }

        void computeCumulativeHistogram()
        {
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                {
                    for (int i = 1; i < 256; i++)
                        iHists[x, y][i] += iHists[x, y][i - 1];
                }
        }

        void computeEqualizationLUT()
        {
            // compute histogram equalization and return a LUT (each bin
            LUTs = new int[8, 8][];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    LUTs[i, j] = computeEqualizationLUT(iHists[i, j]);
                }
        }

        void equalizeHistogram()
        {
            int count = 0;
            int x0, x1, y0, y1;
            Color c, b;
            int gScale;
            // for each grid, apply LUT
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    x0 = (int)Math.Round(i * binXsize);
                    y0 = (int)Math.Round(j * binYsize);
                    x1 = (int)Math.Round((i + 1) * binXsize);
                    y1 = (int)Math.Round((j + 1) * binYsize);
                    for (int x = x0; x < x1; x++)
                        for (int y = y0; y < y1; y++)
                        {
                            // get grayscale color 
                            c = image.GetPixel(x, y);
                            gScale = (int)((c.R + c.G + c.B) / 3);
                            gScale = transformPixelIntensity(x, y, i, j, gScale);
                            b = Color.FromArgb(gScale, gScale, gScale);
                            count++;
                            // set result
                            result.SetPixel(x, y, b);
                        }
                }
        }

        void clipContrast()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    iHists[i, j] = clipContrast(iHists[i, j]);
                }
        }

        int[] clipContrast(int[] histo)
        {
            // in this function, we clip the histogram to a ceiling value
            int middle, top, bottom;
            bottom = 0;
            top = (int)Math.Round(clipLimit * 256);
            int diff;
            do
            {
                diff = 0;
                middle = (int)Math.Round((top + bottom) / 2F);
                for (int i = 0; i < 256; i++)
                {
                    if (histo[i] > middle)
                    {
                        diff += histo[i] - middle;
                    }
                }
                if (diff + middle == top)
                    break;
                else if (diff + middle > top)
                    top = middle;
                else
                    bottom = middle;
            } while (top - bottom > 3F); // clip limit is 3.0F.
            // now, the clip value = middle

            // compute diff
            diff = 0;
            for (int i = 0; i < 256; i++)
            {
                if (histo[i] > middle)
                {
                    diff += histo[i] - middle;
                    histo[i] = middle; // actually clip it here
                }
            }
            // redistribute excess
            diff = (int)Math.Round(diff / 256F); // value to be redistributed to each bin
            for (int i = 0; i < 256; i++)
            {
                histo[i] += diff;
            }
            return histo;
        }

        int transformPixelIntensity(int x, int y, int binX, int binY, int pixVal)
        {
            float val = pixVal;

        
            float x0 = binXsize / 2;
            float x1 = image.Width - x0;
            float y0 = binYsize / 2;
            float y1 = image.Height - y0;
            float xi = (int)((binX + 0.5) * binXsize);
            float yi = (int)((binY + 0.5) * binYsize);
            int dx, dy;
            // first, corners
            if ((x <= x0 && (y <= y0 || y >= y1)) ||
                (x >= x1 && (y <= y0 || y >= y1)))
            {
                // go look in LUT, no interpolation
                val = LUTs[binX, binY][pixVal];
            }
            // then, bands
            else if (x <= x0 || x >= x1)
            {
                // linear interpolation
                if (y < yi)
                {
                    val = (yi - y) * LUTs[binX, binY - 1][pixVal];
                    val += (binYsize - yi + y) * LUTs[binX, binY][pixVal];
                    val /= binYsize;
                }
                else if (y == yi)
                {
                    val = LUTs[binX, binY][pixVal];
                }
                else // y > yi
                {
                    val = (y - yi) * LUTs[binX, binY + 1][pixVal];
                    val += (binYsize - y + yi) * LUTs[binX, binY][pixVal];
                    val /= binYsize;
                }
            }
            else if (y <= y0 || y >= y1)
            {
                // linear interpolation
                if (x < xi)
                {
                    val = (xi - x) * LUTs[binX - 1, binY][pixVal];
                    val += (binXsize - xi + x) * LUTs[binX, binY][pixVal];
                    val /= binXsize;
                }
                else if (x == xi)
                {
                    val = LUTs[binX, binY][pixVal];
                }
                else // x > xi
                {
                    val = (x - xi) * LUTs[binX + 1, binY][pixVal];
                    val += (binXsize - x + xi) * LUTs[binX, binY][pixVal];
                    val /= binXsize;
                }
            }
            // finally, all the rest --> bilinear interp
            else
            {
                dx = (int)Math.Round(x - xi);
                dy = (int)Math.Round(y - yi);
                if (x >= xi)
                {
                    if (y >= yi)
                        val = bilinear_interpolation(dx, dy, (int)binXsize, (int)binYsize,
                                LUTs[binX, binY][pixVal], LUTs[binX + 1, binY][pixVal], LUTs[binX, binY + 1][pixVal], LUTs[binX + 1, binY + 1][pixVal]);
                    else
                        val = bilinear_interpolation(dx, (int)binYsize + dy, (int)binXsize, (int)binYsize,
                                LUTs[binX, binY - 1][pixVal], LUTs[binX + 1, binY - 1][pixVal], LUTs[binX, binY][pixVal], LUTs[binX + 1, binY][pixVal]);
                }
                else
                {
                    if (y >= yi)
                        val = bilinear_interpolation((int)binXsize + dx, dy, (int)binXsize, (int)binYsize,
                            LUTs[binX - 1, binY][pixVal], LUTs[binX, binY][pixVal], LUTs[binX - 1, binY + 1][pixVal], LUTs[binX, binY + 1][pixVal]);
                    else
                        val = bilinear_interpolation((int)binXsize + dx, (int)binYsize + dy, (int)binXsize, (int)binYsize,
                            LUTs[binX - 1, binY - 1][pixVal], LUTs[binX, binY - 1][pixVal], LUTs[binX - 1, binY][pixVal], LUTs[binX, binY][pixVal]);
                }
            }

            return (int)Math.Round(val);
        }

        float bilinear_interpolation(int x, int y, int width, int height, int v1, int v2, int v3, int v4)
        {
            float val1, val2; 
            float res;

            val1 = (x * v2 + (width - x) * v1) / (float)width;
            val2 = (x * v4 + (width - x) * v3) / (float)width;

            res = (val2 * y + ((float)height - y) * val1) / (float)height;

            return res;
        }

        int[] computeEqualizationLUT(int[] hist)
        {
            int[] equalHist = new int[256];
          int count = (int)Math.Round(binXsize * binYsize) - 1;
            for (int i = 0; i < 256; i++)
                equalHist[i] = (int)Math.Round((double)(hist[i] - hist[0]) / count * (grayLevels - 1));

            return equalHist;
        }

        public Bitmap Process()
        {
            result = new Bitmap(image);

            // 1. compute histograms
            computeHistogram();

            // 2. clip contrast
            clipContrast();

            // 3. compute cumulative histograms
            computeCumulativeHistogram();

            // 4. for each histogram, compute the equalization LUT
            computeEqualizationLUT();

            // 5. apply transformation based on LUTs
            equalizeHistogram();

            return result;
        }
    }

    public partial class FormPrPNI : Form
    {
        Bitmap ImgGray;
        private static double contrastLimit = 2.5F;

        public FormPrPNI()
        {
            InitializeComponent();
            pbOriginalImage.Visible = false;
            chartOrgImgHisto.Visible = false;
            chart1.Visible = false;
            button1.Visible = false;
            textBox1.Visible = false;

            hideAllFormElements();
        }
        

        private void hideAllFormElements()
        {
            gbBinarization.Visible = false; // grupul de control pentru operatia binarizare 
            pbProcessedImage.Visible = false; // imaginea procesata
            dgvTableView.Visible = false; // dataGridView 
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideAllFormElements();
        }
       
        private void grayScaleImageProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideAllFormElements();
        }

        private void openGrayImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdOpenImageFile.Multiselect = false;
            if (ofdOpenImageFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofdOpenImageFile.FileName.ToString();

                ImgGray = new Bitmap(fileName); // incarcare imagine din fileName

              
                pbOriginalImage.Size = ImgGray.Size;
                pbOriginalImage.Image = ImgGray;
                pbOriginalImage.Visible = true;

                button1.Visible =true;
                textBox1.Visible =true;


                pbProcessedImage.Size = pbOriginalImage.Size;
               histoShow(histograma(ImgGray),chartOrgImgHisto);

            }
        }

        static private int[] histograma(Bitmap bitmap)
        {

            Color c;
            int gScale;
            int[] histo = new int[256];
            for (int i = 0; i < bitmap.Height; i++)
                for (int j = 0; j < bitmap.Width; j++)
                {    // Get pixel color 
                        c = bitmap.GetPixel(i, j);
                    // convert c to grayscale
                    gScale = (int)((c.R + c.G + c.B) / 3);
                        // put value in iHisto
                        histo[gScale]++;
                
                }
            return histo;
        }

        // Afisare histograma pe form
        private void histoShow(int[] _histo, System.Windows.Forms.DataVisualization.Charting.Chart _chart)
        {
        
            _chart.Top = pbOriginalImage.Top + pbOriginalImage.Height + 10;
            _chart.Series[0].Points.Clear();
            for (int i = 0; i < _histo.Length; i++)
                _chart.Series[0].Points.AddXY(i, _histo[i]);
            _chart.Visible = true;
        }

        private void ButtonCLAHE_Click(object sender,EventArgs e)
        {
            int thdBinTextBox = Convert.ToByte(tbThreshold.Text);

            Clahe clahe = new Clahe((float) contrastLimit, ImgGray); 
            Bitmap ImgBin = clahe.Process(); 

            pbProcessedImage.Size = ImgBin.Size;
            pbProcessedImage.Image = ImgBin;
            pbProcessedImage.Visible = true;
             histoShow(histograma(ImgBin), chart1);

    }

       
        private void labelThreshold_Click(object sender, EventArgs e)
        {
            contrastLimit =Convert.ToDouble(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }
    }
}
