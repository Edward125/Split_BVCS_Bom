using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Edward;
using CCWin;
using System.IO;

namespace Split_BVCS_Bom
{
    public partial class frmMain:Skin_Mac 
    {
        public frmMain()
        {
            InitializeComponent();
        }


        #region Var

        string sysFolder = Application.StartupPath + @"\SplitBOM";


        #endregion
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Split BVCS BOM for double panel,Ver.:" + Application.ProductVersion + ",Author:Edward Song";
            txtBOMFile.SetWatermark("Double Click here to select a BOM file");
            txtBOMFolder.SetWatermark("Double Click here to select a BOM folder");
            //
            //check folder
            //
            if (!Directory.Exists(sysFolder))
                Directory.CreateDirectory(sysFolder);
           
        }

        private void txtBOMFolder_DoubleClick(object sender, EventArgs e)
        {
            openFolder(txtBOMFolder);
        }

        private void txtBOMFile_DoubleClick(object sender, EventArgs e)
        {
            openFile(txtBOMFile);
        }


        /// <summary>
        /// select a folder
        /// </summary>
        /// <param name="textbox">show the path textbox</param>
        private void openFolder(TextBox textbox)
        {
            FolderBrowserDialog openfolderdiag = new FolderBrowserDialog();
            if (openfolderdiag.ShowDialog() == DialogResult.OK)
                txtBOMFolder.Text = openfolderdiag.SelectedPath;

        }

        /// <summary>
        /// select a file
        /// </summary>
        /// <param name="textbox">show the file path textbox</param>
        private void openFile(TextBox textbox)
        {
            OpenFileDialog openfilediag = new OpenFileDialog();
            openfilediag.Filter = "txt Files(*.txt)|*.txt|All Files(*.*)|*.*";
            if (openfilediag.ShowDialog() == DialogResult.OK)
                textbox.Text = openfilediag.FileName;

        }

        private void btnSplitBOM_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty (txtBOMFile.Text.Trim ()))
                return;
            this.Enabled = false;
            SplitSigleBOM(txtBOMFile.Text.Trim());
            this.Enabled = true;
        }

        private void btnSplitFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBOMFolder.Text.Trim()))
                return;

            this.Enabled = false;

            DirectoryInfo dircinfo = new DirectoryInfo(txtBOMFolder.Text.Trim());

            //create new folder
            if (!Directory.Exists(@sysFolder + @"\" + @dircinfo.Name))
                Directory.CreateDirectory(@sysFolder + @"\" + @dircinfo.Name);

            foreach (FileInfo fileinfo in dircinfo.GetFiles())
            {
                SplitSigleBOM(fileinfo.FullName, @sysFolder + @"\" + @dircinfo.Name);
            }

            this.Enabled = true;
        }




        /// <summary>
        /// split a single BOM
        /// </summary>
        /// <param name="inbomfile">old BOM file</param>
        private void SplitSigleBOM(string inbomfile)
        {
            int i = 0;
            FileInfo fileinfo = new FileInfo(inbomfile);
            StreamReader reader = new StreamReader(inbomfile);           
            StreamWriter writer = new StreamWriter(@sysFolder + @"\" + @fileinfo.Name );
            string lineString = string.Empty ;
            do
            {
               lineString = reader.ReadLine ();
                i ++;
                Application.DoEvents();
                this.Text = "Split the BOM:" + fileinfo.Name + ",Lines:" + i;

                if (lineString != null)
                {

                    if (!lineString.StartsWith("-") && lineString.EndsWith("1"))
                    {
                        lineString =  lineString.Substring(0, lineString.Length - 2);
                        writer.WriteLine(lineString);
                       
                    }
                    else if (!lineString.StartsWith("-") && lineString.EndsWith("2"))
                    {
                    }
                    else
                    {
                       writer.WriteLine(lineString);
                    }

                }


            } while ( lineString != null   );

            reader.Close();
            writer.Close();
            this.Text = "Split BVCS BOM for double panel,Ver.:" + Application.ProductVersion + ",Author:Edward Song";
        }

        /// <summary>
        /// split a single BOM
        /// </summary>
        /// <param name="inbomfile">old BOM file</param>
        /// <param name="outfolder">new BOM out folder</param>
        private void SplitSigleBOM(string inbomfile,string outfolder)
        {
            int i = 0;
            FileInfo fileinfo = new FileInfo(inbomfile);
            StreamReader reader = new StreamReader(inbomfile);
            StreamWriter writer = new StreamWriter(@outfolder  + @"\" + @fileinfo.Name);
            string lineString = string.Empty;
            do
            {
                lineString = reader.ReadLine();
                i++;
                Application.DoEvents();
                this.Text = "Split the BOM:" + fileinfo.Name + ",Lines:" + i;

                if (lineString != null)
                {

                    if (!lineString.StartsWith("-") && lineString.EndsWith("1"))
                    {
                        lineString = lineString.Substring(0, lineString.Length - 2);
                        writer.WriteLine(lineString);

                    }
                    else if (!lineString.StartsWith("-") && lineString.EndsWith("2"))
                    {
                    }
                    else
                    {
                        writer.WriteLine(lineString);
                    }

                }


            } while (lineString != null);

            reader.Close();
            writer.Close();
            this.Text = "Split BVCS BOM for double panel,Ver.:" + Application.ProductVersion + ",Author:Edward Song";
        }

        private void txtBOMFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
