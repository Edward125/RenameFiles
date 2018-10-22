using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Edward;
using System.IO;

namespace RenameFiles
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        private void frmMain_Load(object sender, EventArgs e)
            
        {
            this.Text = "批量删除文件名中的-,Ver:" + Application.ProductVersion;
            txtFolder.SetWatermark("双击此处选择需要批量修改文件名的文件夹");
        }



        private void btnGo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text.Trim())) 
            {
                txtFolder.Focus ();
                return;
            }


            if (!Directory.Exists (txtFolder.Text.Trim ()))
            {
                MessageBox.Show("文件夹地址不存在,请重新输入", "文件夹不存在", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtFolder.SelectAll();
                txtFolder.Focus();
               return;
            }

            txtFolder.Enabled = false;
            btnGo.Enabled = false;

            long  i = 0;

            //DirectoryInfo di = new DirectoryInfo(txtFolder.Text.Trim ());
            //FileInfo[] fis = di.GetFiles();
            //foreach (FileInfo fi in fis)
            //{
            //    if (fi.Name.Contains("-"))
            //    {
            //        string newName = fi.Name.Replace("-", "");
            //        File.Move(fi.FullName, txtFolder.Text.Trim() + @"\" + newName);
            //        File.Delete(fi.FullName);
            //        i++;
            //    }

            //}

            List<FileInformation> list = new List<FileInformation>();
            list =  DirectoryAllFiles.GetAllFiles(new System.IO.DirectoryInfo(@txtFolder.Text.Trim()));

            foreach (var item in list)
            {
                //
                //Console.WriteLine(string.Format("文件名：{0}---文件目录{1}", item.FileName, item.FilePath));
                if (item.FileName.Contains("-"))
                {
                    //this.Text = "正在处理:" + item.FileName;
                    string newName = item.FileName.Replace("-", "");
                    try
                    {

                        if (File.Exists(item.FilePath))
                        {
                            File.Move(item.FilePath, item.FileDirectory + @"\" + newName);
                            File.Delete(item.FilePath);
                            i++;
                        }


             
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("修改文件名出现错误," + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
     

                }
            }



            MessageBox.Show("共计完成修改文件个数:" + i, "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFolder.Enabled = true;
            btnGo.Enabled = true;


        }

        private void txtFolder_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                txtFolder.Text = fbd.SelectedPath;
        }



        public class DirectoryAllFiles
        {
            static List<FileInformation> FileList = new List<FileInformation>();
            public static List<FileInformation> GetAllFiles(DirectoryInfo dir)
            {
                FileInfo[] allFile = dir.GetFiles();
                foreach (FileInfo fi in allFile)
                {
                    FileList.Add(new FileInformation { FileName = fi.Name, FilePath = fi.FullName , FileDirectory  = fi.DirectoryName });
                }
                DirectoryInfo[] allDir = dir.GetDirectories();
                foreach (DirectoryInfo d in allDir)
                {
                    GetAllFiles(d);
                }
                return FileList;
            }
        }

        public class FileInformation
        {
            public string FileName { get; set; }
            public string FilePath { get; set; }
            public string FileDirectory { get; set; }
        }


    }
}