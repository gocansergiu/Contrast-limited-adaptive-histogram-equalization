namespace ImageProcessingProjectApp
{
    partial class FormPrPNI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGrayImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openColorImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleImageProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastLimitedHEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsAndTricksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMultipleImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAllImagesFromFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spatialImageProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableDataViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareDevelopmentTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdOpenImageFile = new System.Windows.Forms.OpenFileDialog();
            this.pbOriginalImage = new System.Windows.Forms.PictureBox();
            this.pbProcessedImage = new System.Windows.Forms.PictureBox();
            this.chartOrgImgHisto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ofdSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonBinarization = new System.Windows.Forms.Button();
            this.tbThreshold = new System.Windows.Forms.TextBox();
            this.gbBinarization = new System.Windows.Forms.GroupBox();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.dgvTableView = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcessedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrgImgHisto)).BeginInit();
            this.gbBinarization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.grayScaleImageProcessingToolStripMenuItem,
            this.tipsAndTricksToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1259, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGrayImageToolStripMenuItem,
            this.openColorImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openGrayImageToolStripMenuItem
            // 
            this.openGrayImageToolStripMenuItem.Name = "openGrayImageToolStripMenuItem";
            this.openGrayImageToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openGrayImageToolStripMenuItem.Text = "Open Gray Image";
            this.openGrayImageToolStripMenuItem.Click += new System.EventHandler(this.openGrayImageToolStripMenuItem_Click);
            // 
            // openColorImageToolStripMenuItem
            // 
            this.openColorImageToolStripMenuItem.Name = "openColorImageToolStripMenuItem";
            this.openColorImageToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openColorImageToolStripMenuItem.Text = "Open Color Image";
     //       this.openColorImageToolStripMenuItem.Click += new System.EventHandler(this.openColorImageToolStripMenuItem_Click);
            // 
            // grayScaleImageProcessingToolStripMenuItem
            // 
            this.grayScaleImageProcessingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarizationToolStripMenuItem,
            this.contrastLimitedHEToolStripMenuItem});
            this.grayScaleImageProcessingToolStripMenuItem.Name = "grayScaleImageProcessingToolStripMenuItem";
            this.grayScaleImageProcessingToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.grayScaleImageProcessingToolStripMenuItem.Text = "GrayScaleImageProcessing ";
            this.grayScaleImageProcessingToolStripMenuItem.Click += new System.EventHandler(this.grayScaleImageProcessingToolStripMenuItem_Click);
            // 
          
       
            // 
            // contrastLimitedHEToolStripMenuItem
            // 
            this.contrastLimitedHEToolStripMenuItem.Name = "contrastLimitedHEToolStripMenuItem";
            this.contrastLimitedHEToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.contrastLimitedHEToolStripMenuItem.Text = "CLAHE";
            this.contrastLimitedHEToolStripMenuItem.Click += new System.EventHandler(this.ButtonCLAHE_Click);
            // 
            // tipsAndTricksToolStripMenuItem
            // 
            this.tipsAndTricksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToMatrixToolStripMenuItem,
            this.openMultipleImagesToolStripMenuItem,
            this.openAllImagesFromFolderToolStripMenuItem,
            this.spatialImageProcessingToolStripMenuItem,
            this.tableDataViewToolStripMenuItem});
            this.tipsAndTricksToolStripMenuItem.Name = "tipsAndTricksToolStripMenuItem";
            this.tipsAndTricksToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.tipsAndTricksToolStripMenuItem.Text = "TipsAndTricks";
          //  this.tipsAndTricksToolStripMenuItem.Click += new System.EventHandler(this.tipsAndTricksToolStripMenuItem_Click);
            // 
            // imageToMatrixToolStripMenuItem
            // 
            this.imageToMatrixToolStripMenuItem.Name = "imageToMatrixToolStripMenuItem";
            this.imageToMatrixToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.imageToMatrixToolStripMenuItem.Text = "Image To Matrix";
       //     this.imageToMatrixToolStripMenuItem.Click += new System.EventHandler(this.imageToMatrixToolStripMenuItem_Click);
            // 
            // openMultipleImagesToolStripMenuItem
            // 
            this.openMultipleImagesToolStripMenuItem.Name = "openMultipleImagesToolStripMenuItem";
            this.openMultipleImagesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.openMultipleImagesToolStripMenuItem.Text = "Open Multiple Images";
          //  this.openMultipleImagesToolStripMenuItem.Click += new System.EventHandler(this.openMultipleImagesToolStripMenuItem_Click);
            // 
            // openAllImagesFromFolderToolStripMenuItem
            // 
            this.openAllImagesFromFolderToolStripMenuItem.Name = "openAllImagesFromFolderToolStripMenuItem";
            this.openAllImagesFromFolderToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.openAllImagesFromFolderToolStripMenuItem.Text = "Open All Images from Folder";
          //  this.openAllImagesFromFolderToolStripMenuItem.Click += new System.EventHandler(this.openAllImagesFromFolderToolStripMenuItem_Click);
            // 
            // spatialImageProcessingToolStripMenuItem
            // 
            this.spatialImageProcessingToolStripMenuItem.Name = "spatialImageProcessingToolStripMenuItem";
            this.spatialImageProcessingToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.spatialImageProcessingToolStripMenuItem.Text = "Spatial Image Processing";
        //    this.spatialImageProcessingToolStripMenuItem.Click += new System.EventHandler(this.spatialImageProcessingToolStripMenuItem_Click);
            // 
            // tableDataViewToolStripMenuItem
            // 
            this.tableDataViewToolStripMenuItem.Name = "tableDataViewToolStripMenuItem";
            this.tableDataViewToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.tableDataViewToolStripMenuItem.Text = "Table Data View";
       //     this.tableDataViewToolStripMenuItem.Click += new System.EventHandler(this.tableDataViewToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareDevelopmentTeamToolStripMenuItem,
            this.softwareTutorialToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // softwareDevelopmentTeamToolStripMenuItem
            // 
            this.softwareDevelopmentTeamToolStripMenuItem.Name = "softwareDevelopmentTeamToolStripMenuItem";
            this.softwareDevelopmentTeamToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.softwareDevelopmentTeamToolStripMenuItem.Text = "Development Team";
         //   this.softwareDevelopmentTeamToolStripMenuItem.Click += new System.EventHandler(this.softwareDevelopmentTeamToolStripMenuItem_Click);
            // 
            // softwareTutorialToolStripMenuItem
            // 
            this.softwareTutorialToolStripMenuItem.Name = "softwareTutorialToolStripMenuItem";
            this.softwareTutorialToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.softwareTutorialToolStripMenuItem.Text = "Help";
     //       this.softwareTutorialToolStripMenuItem.Click += new System.EventHandler(this.softwareTutorialToolStripMenuItem_Click);
            // 
            // ofdOpenImageFile
            // 
            this.ofdOpenImageFile.FileName = "openFileDialog1";
            // 
            // pbOriginalImage
            // 
            this.pbOriginalImage.Location = new System.Drawing.Point(12, 82);
            this.pbOriginalImage.Name = "pbOriginalImage";
            this.pbOriginalImage.Size = new System.Drawing.Size(188, 136);
            this.pbOriginalImage.TabIndex = 1;
            this.pbOriginalImage.TabStop = false;
            // 
            // pbProcessedImage
            // 
            this.pbProcessedImage.Location = new System.Drawing.Point(527, 82);
            this.pbProcessedImage.Name = "pbProcessedImage";
            this.pbProcessedImage.Size = new System.Drawing.Size(188, 136);
            this.pbProcessedImage.TabIndex = 2;
            this.pbProcessedImage.TabStop = false;
            // 
            // chartOrgImgHisto
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOrgImgHisto.ChartAreas.Add(chartArea1);
            this.chartOrgImgHisto.Location = new System.Drawing.Point(0, 224);
            this.chartOrgImgHisto.Name = "chartOrgImgHisto";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartOrgImgHisto.Series.Add(series1);
            this.chartOrgImgHisto.Size = new System.Drawing.Size(300, 160);
            this.chartOrgImgHisto.TabIndex = 3;
            this.chartOrgImgHisto.Text = "chartOrgImgHisto";
            // 
            // ofdSelectFolder
            // 
            this.ofdSelectFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // buttonBinarization
            // 
            this.buttonBinarization.Location = new System.Drawing.Point(178, 18);
            this.buttonBinarization.Name = "buttonBinarization";
            this.buttonBinarization.Size = new System.Drawing.Size(75, 23);
            this.buttonBinarization.TabIndex = 6;
            this.buttonBinarization.Text = "Binarization";
            this.buttonBinarization.UseVisualStyleBackColor = true;
         //   this.buttonBinarization.Click += new System.EventHandler(this.ButtonEqualization_Click);
            // 
            // tbThreshold
            // 
            this.tbThreshold.Location = new System.Drawing.Point(127, 21);
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(45, 20);
            this.tbThreshold.TabIndex = 4;
            this.tbThreshold.Text = "128";
            // 
            // gbBinarization
            // 
            this.gbBinarization.Controls.Add(this.tbThreshold);
            this.gbBinarization.Controls.Add(this.buttonBinarization);
            this.gbBinarization.Controls.Add(this.labelThreshold);
            this.gbBinarization.Location = new System.Drawing.Point(965, 37);
            this.gbBinarization.Name = "gbBinarization";
            this.gbBinarization.Size = new System.Drawing.Size(268, 48);
            this.gbBinarization.TabIndex = 7;
            this.gbBinarization.TabStop = false;
            this.gbBinarization.Text = "Image Binarization";
            // 
            // labelThreshold
            // 
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.Location = new System.Drawing.Point(13, 25);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(111, 13);
            this.labelThreshold.TabIndex = 5;
            this.labelThreshold.Text = "Binarization Threshold";
            this.labelThreshold.Click += new System.EventHandler(this.labelThreshold_Click);
            // 
            // dgvTableView
            // 
            this.dgvTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableView.Location = new System.Drawing.Point(965, 174);
            this.dgvTableView.Name = "dgvTableView";
            this.dgvTableView.Size = new System.Drawing.Size(187, 155);
            this.dgvTableView.TabIndex = 8;
          //  this.dgvTableView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableView_CellContentClick);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(448, 224);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 160);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(884, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Contrast Limited";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.labelThreshold_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(778, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormPrPNI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1259, 775);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvTableView);
            this.Controls.Add(this.gbBinarization);
            this.Controls.Add(this.chartOrgImgHisto);
            this.Controls.Add(this.pbProcessedImage);
            this.Controls.Add(this.pbOriginalImage);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "FormPrPNI";
            this.Text = "Digital Image Processing Project";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcessedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrgImgHisto)).EndInit();
            this.gbBinarization.ResumeLayout(false);
            this.gbBinarization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.OpenFileDialog ofdOpenImageFile;
        private System.Windows.Forms.PictureBox pbOriginalImage;
        private System.Windows.Forms.PictureBox pbProcessedImage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrgImgHisto;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleImageProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openColorImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGrayImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareDevelopmentTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipsAndTricksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMultipleImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAllImagesFromFolderToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog ofdSelectFolder;
        private System.Windows.Forms.ToolStripMenuItem spatialImageProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableDataViewToolStripMenuItem;
        private System.Windows.Forms.Button buttonBinarization;
        private System.Windows.Forms.TextBox tbThreshold;
        private System.Windows.Forms.GroupBox gbBinarization;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.DataGridView dgvTableView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem contrastLimitedHEToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

