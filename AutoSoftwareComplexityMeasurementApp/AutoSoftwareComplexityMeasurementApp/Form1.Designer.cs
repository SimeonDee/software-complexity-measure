namespace AutoSoftwareComplexityMeasurementApp
{
    partial class FrmMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlResultMain = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAllMetrics = new System.Windows.Forms.RadioButton();
            this.radMcCabeMetric = new System.Windows.Forms.RadioButton();
            this.radHalsteadMetric = new System.Windows.Forms.RadioButton();
            this.radSLOCMetric = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbSourceCode = new System.Windows.Forms.RichTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblMetricResultsHeader = new System.Windows.Forms.Label();
            this.pnlAnalysisResults = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlResultMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTOMATED SOFTWARE COMPLEXITY MEASUREMENT";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlResultMain);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(19, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1331, 597);
            this.panel1.TabIndex = 1;
            // 
            // pnlResultMain
            // 
            this.pnlResultMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlResultMain.Controls.Add(this.pnlAnalysisResults);
            this.pnlResultMain.Controls.Add(this.lblMetricResultsHeader);
            this.pnlResultMain.Controls.Add(this.label5);
            this.pnlResultMain.Location = new System.Drawing.Point(816, 10);
            this.pnlResultMain.Name = "pnlResultMain";
            this.pnlResultMain.Size = new System.Drawing.Size(506, 578);
            this.pnlResultMain.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(149, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "COMPLEXITY ANALYSIS RESULTS";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 578);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(18, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(761, 126);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnAnalyze);
            this.panel5.Location = new System.Drawing.Point(512, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 84);
            this.panel5.TabIndex = 2;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnalyze.Enabled = false;
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(13, 7);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(207, 69);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "ANALYZE COMPLEXITIES";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radAllMetrics);
            this.groupBox1.Controls.Add(this.radMcCabeMetric);
            this.groupBox1.Controls.Add(this.radHalsteadMetric);
            this.groupBox1.Controls.Add(this.radSLOCMetric);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Metric";
            // 
            // radAllMetrics
            // 
            this.radAllMetrics.AutoSize = true;
            this.radAllMetrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAllMetrics.Location = new System.Drawing.Point(338, 54);
            this.radAllMetrics.Name = "radAllMetrics";
            this.radAllMetrics.Size = new System.Drawing.Size(81, 19);
            this.radAllMetrics.TabIndex = 3;
            this.radAllMetrics.Text = "All Metrics";
            this.radAllMetrics.UseVisualStyleBackColor = true;
            // 
            // radMcCabeMetric
            // 
            this.radMcCabeMetric.AutoSize = true;
            this.radMcCabeMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMcCabeMetric.Location = new System.Drawing.Point(14, 54);
            this.radMcCabeMetric.Name = "radMcCabeMetric";
            this.radMcCabeMetric.Size = new System.Drawing.Size(288, 19);
            this.radMcCabeMetric.TabIndex = 2;
            this.radMcCabeMetric.Text = "McCabe Cyclomatic Complexity Metrics (MCCM)";
            this.radMcCabeMetric.UseVisualStyleBackColor = true;
            // 
            // radHalsteadMetric
            // 
            this.radHalsteadMetric.AutoSize = true;
            this.radHalsteadMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHalsteadMetric.Location = new System.Drawing.Point(338, 22);
            this.radHalsteadMetric.Name = "radHalsteadMetric";
            this.radHalsteadMetric.Size = new System.Drawing.Size(117, 19);
            this.radHalsteadMetric.TabIndex = 1;
            this.radHalsteadMetric.Text = "Halstead Metrics";
            this.radHalsteadMetric.UseVisualStyleBackColor = true;
            // 
            // radSLOCMetric
            // 
            this.radSLOCMetric.AutoSize = true;
            this.radSLOCMetric.Checked = true;
            this.radSLOCMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSLOCMetric.Location = new System.Drawing.Point(15, 22);
            this.radSLOCMetric.Name = "radSLOCMetric";
            this.radSLOCMetric.Size = new System.Drawing.Size(179, 19);
            this.radSLOCMetric.TabIndex = 0;
            this.radSLOCMetric.TabStop = true;
            this.radSLOCMetric.Text = "Source Line of Code (SLOC)";
            this.radSLOCMetric.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtFilePath);
            this.panel2.Controls.Add(this.txtFileName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rtbSourceCode);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(17, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 411);
            this.panel2.TabIndex = 4;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(209, 378);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(538, 20);
            this.txtFilePath.TabIndex = 7;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(209, 351);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(536, 20);
            this.txtFileName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "File Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "File Name";
            // 
            // rtbSourceCode
            // 
            this.rtbSourceCode.Location = new System.Drawing.Point(209, 8);
            this.rtbSourceCode.Name = "rtbSourceCode";
            this.rtbSourceCode.Size = new System.Drawing.Size(538, 319);
            this.rtbSourceCode.TabIndex = 3;
            this.rtbSourceCode.Text = "";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(14, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(169, 153);
            this.panel7.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upload Source Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblMetricResultsHeader
            // 
            this.lblMetricResultsHeader.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetricResultsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMetricResultsHeader.Location = new System.Drawing.Point(15, 46);
            this.lblMetricResultsHeader.Name = "lblMetricResultsHeader";
            this.lblMetricResultsHeader.Size = new System.Drawing.Size(481, 27);
            this.lblMetricResultsHeader.TabIndex = 1;
            this.lblMetricResultsHeader.Text = "Halstead Complexity Results";
            this.lblMetricResultsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAnalysisResults
            // 
            this.pnlAnalysisResults.AutoScroll = true;
            this.pnlAnalysisResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAnalysisResults.Location = new System.Drawing.Point(15, 82);
            this.pnlAnalysisResults.Name = "pnlAnalysisResults";
            this.pnlAnalysisResults.Size = new System.Drawing.Size(481, 482);
            this.pnlAnalysisResults.TabIndex = 2;
            // 
            // FrmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmMainPage";
            this.Text = "Automated Complexity Measure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnlResultMain.ResumeLayout(false);
            this.pnlResultMain.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlResultMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radAllMetrics;
        private System.Windows.Forms.RadioButton radMcCabeMetric;
        private System.Windows.Forms.RadioButton radHalsteadMetric;
        private System.Windows.Forms.RadioButton radSLOCMetric;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbSourceCode;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblMetricResultsHeader;
        private System.Windows.Forms.Panel pnlAnalysisResults;
    }
}

