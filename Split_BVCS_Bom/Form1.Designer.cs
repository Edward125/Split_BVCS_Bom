namespace Split_BVCS_Bom
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.btnSplitFolder = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtBOMFolder = new System.Windows.Forms.TextBox();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.btnSplitBOM = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.txtBOMFile = new System.Windows.Forms.TextBox();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.Controls.Add(this.btnSplitFolder);
            this.skinGroupBox1.Controls.Add(this.skinLabel1);
            this.skinGroupBox1.Controls.Add(this.txtBOMFolder);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(34, 43);
            this.skinGroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinGroupBox1.RectBackColor = System.Drawing.SystemColors.Control;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(703, 70);
            this.skinGroupBox1.TabIndex = 0;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "SplitFolderAllBom";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.SystemColors.Control;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btnSplitFolder
            // 
            this.btnSplitFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnSplitFolder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSplitFolder.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSplitFolder.DownBack = null;
            this.btnSplitFolder.Location = new System.Drawing.Point(599, 29);
            this.btnSplitFolder.MouseBack = null;
            this.btnSplitFolder.Name = "btnSplitFolder";
            this.btnSplitFolder.NormlBack = null;
            this.btnSplitFolder.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnSplitFolder.Size = new System.Drawing.Size(85, 30);
            this.btnSplitFolder.TabIndex = 3;
            this.btnSplitFolder.Text = "Split Folder";
            this.btnSplitFolder.UseVisualStyleBackColor = false;
            this.btnSplitFolder.Click += new System.EventHandler(this.btnSplitFolder_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(17, 33);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(111, 17);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "BOM Folder Path:";
            // 
            // txtBOMFolder
            // 
            this.txtBOMFolder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBOMFolder.Location = new System.Drawing.Point(133, 30);
            this.txtBOMFolder.Name = "txtBOMFolder";
            this.txtBOMFolder.Size = new System.Drawing.Size(449, 26);
            this.txtBOMFolder.TabIndex = 0;
            this.txtBOMFolder.DoubleClick += new System.EventHandler(this.txtBOMFolder_DoubleClick);
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.Controls.Add(this.btnSplitBOM);
            this.skinGroupBox2.Controls.Add(this.skinLabel2);
            this.skinGroupBox2.Controls.Add(this.txtBOMFile);
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox2.Location = new System.Drawing.Point(34, 121);
            this.skinGroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinGroupBox2.RectBackColor = System.Drawing.SystemColors.Control;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(703, 76);
            this.skinGroupBox2.TabIndex = 1;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "SplitSingleBom";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.SystemColors.Control;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btnSplitBOM
            // 
            this.btnSplitBOM.BackColor = System.Drawing.Color.Transparent;
            this.btnSplitBOM.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSplitBOM.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSplitBOM.DownBack = null;
            this.btnSplitBOM.Location = new System.Drawing.Point(599, 30);
            this.btnSplitBOM.MouseBack = null;
            this.btnSplitBOM.Name = "btnSplitBOM";
            this.btnSplitBOM.NormlBack = null;
            this.btnSplitBOM.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnSplitBOM.Size = new System.Drawing.Size(85, 30);
            this.btnSplitBOM.TabIndex = 4;
            this.btnSplitBOM.Text = "Split BOM";
            this.btnSplitBOM.UseVisualStyleBackColor = false;
            this.btnSplitBOM.Click += new System.EventHandler(this.btnSplitBOM_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(17, 37);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(101, 17);
            this.skinLabel2.TabIndex = 3;
            this.skinLabel2.Text = "SingleBOMPath:";
            // 
            // txtBOMFile
            // 
            this.txtBOMFile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBOMFile.Location = new System.Drawing.Point(133, 34);
            this.txtBOMFile.Name = "txtBOMFile";
            this.txtBOMFile.Size = new System.Drawing.Size(449, 26);
            this.txtBOMFile.TabIndex = 1;
            this.txtBOMFile.TextChanged += new System.EventHandler(this.txtBOMFile_TextChanged);
            this.txtBOMFile.DoubleClick += new System.EventHandler(this.txtBOMFile_DoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 229);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinButton btnSplitFolder;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.TextBox txtBOMFolder;
        private CCWin.SkinControl.SkinButton btnSplitBOM;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.TextBox txtBOMFile;
    }
}

