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


            CheckStatus (chk1, txtold1, txtnew1);
            CheckStatus(chk2, txtold2, txtnew2);
            CheckStatus(chk3, txtold3, txtnew3);
            CheckStatus(chk4, txtold4, txtnew4);
            CheckStatus(chk5, txtold5, txtnew5);


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

            grbSetting.Enabled = false;
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
                string newName = "";

                if (chk1.Checked  && !string.IsNullOrEmpty (txtold1.Text.Trim ()))
                {
                    if (item.FileName.Contains (@txtold1.Text.Trim ()))
                        newName = item.FileName.Replace(@txtold1.Text.Trim(), @txtnew1.Text.Trim());

                }

                if (chk2.Checked && !string.IsNullOrEmpty(txtold2.Text.Trim()))
                {
                    if (item.FileName.Contains(@txtold2.Text.Trim()))
                        newName = item.FileName.Replace(@txtold2.Text.Trim(), @txtnew2.Text.Trim());

                }

                if (chk3.Checked && !string.IsNullOrEmpty(txtold3.Text.Trim()))
                {
                    if (item.FileName.Contains(@txtold3.Text.Trim()))
                        newName = item.FileName.Replace(@txtold3.Text.Trim(), @txtnew3.Text.Trim());

                }

                if (chk4.Checked && !string.IsNullOrEmpty(txtold4.Text.Trim()))
                {
                    if (item.FileName.Contains(@txtold4.Text.Trim()))
                        newName = item.FileName.Replace(@txtold4.Text.Trim(), @txtnew4.Text.Trim());

                }

                if (chk5.Checked && !string.IsNullOrEmpty(txtold5.Text.Trim()))
                {
                    if (item.FileName.Contains(@txtold5.Text.Trim()))
                        newName = item.FileName.Replace(@txtold5.Text.Trim(), @txtnew5.Text.Trim());

                }






                //if (item.FileName.Contains("-"))
                //{
                //    newName = item.FileName.Replace("-", "");
                //}
                //if (newName.Contains("联网更新"))
                //    newName = newName.Replace("联网更新", "");

                    //this.Text = "正在处理:" + item.FileName;

                if (!string.IsNullOrEmpty(newName) && (newName != item.FileName))
                {


                    try
                    {
                        if (File.Exists(item.FilePath))
                        {
                            i++;
                            this.Text = "正在处理第:" + i + "个文件";
                            File.Move(item.FilePath, item.FileDirectory + @"\" + newName);
                            //File.Delete(item.FilePath);

                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("修改文件名出现错误," + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }



            MessageBox.Show("共计完成修改文件个数:" + i, "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Text = "批量删除文件名中的-,Ver:" + Application.ProductVersion;
            txtFolder.Enabled = true;
            btnGo.Enabled = true;
            grbSetting.Enabled = true;

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



        private void CheckStatus(CheckBox check, TextBox txtold, TextBox txtnew)
        {
            if (check.Checked)
            {
                txtold.BackColor = Color.LimeGreen;
                txtnew.BackColor = Color.LimeGreen;
            }
            else
            {
                txtold.BackColor = Color.OrangeRed;
                txtnew.BackColor = Color.OrangeRed;
            }
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatus(chk1, txtold1, txtnew1);
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatus(chk2, txtold2, txtnew2);
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatus(chk3, txtold3, txtnew3);
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatus(chk4, txtold4, txtnew4);
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatus(chk5, txtold5, txtnew5);
        }

        private void txtFolder_Click(object sender, EventArgs e)
        {
            txtFolder.SelectAll();
        }

    }
}