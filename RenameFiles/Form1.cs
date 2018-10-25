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
            this.Text = "批量修改文件名,Ver:" + Application.ProductVersion;

            InitUI();



        }


        /// <summary>
        /// 
        /// </summary>
        private void InitUI()
        {
            txtFolder.SetWatermark("双击此处选择需要批量修改文件名的文件夹");
            txtAddExtension.SetWatermark("扩展名,如.txt");
            CheckStatus(chk1, txtold1, txtnew1);
            CheckStatus(chk2, txtold2, txtnew2);
            CheckStatus(chk3, txtold3, txtnew3);
            CheckStatus(chk4, txtold4, txtnew4);
            CheckStatus(chk5, txtold5, txtnew5);
            setListview(lstViewFileInfoView);
        }


        private void setListview(ListView listview)
        {
            listview.View = View.Details;
            listview.MultiSelect = false;
            listview.AutoArrange = true;
            listview.GridLines = true;
            listview.FullRowSelect = true;
            listview.Columns.Add("序号", 50, HorizontalAlignment.Center);
            listview.Columns.Add("文件类型", 80, HorizontalAlignment.Center);
            listview.Columns.Add("原始文件名", 150, HorizontalAlignment.Center);
            listview.Columns.Add("新文件名", 150, HorizontalAlignment.Center);
            listview.Columns.Add("文件路径", 350, HorizontalAlignment.Center);

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



            if (chkIncludeFolders.Checked)  //包含子文件夹
            {

            }
            else                            //不包含子文件夹
            {

            }





            List<FileInformation> list = new List<FileInformation>();
            list =  DirectoryAllFiles.GetAllFiles(new System.IO.DirectoryInfo(@txtFolder.Text.Trim()));

            foreach (var item in list)
            {
                //
                //Console.WriteLine(string.Format("文件名：{0}---文件目录{1}", item.FileName, item.FilePath));
                string newName = CheckFilesName(item.FileName);

                //if (chk1.Checked  && !string.IsNullOrEmpty (txtold1.Text.Trim ()))
                //{
                //    if (item.FileName.Contains (@txtold1.Text.Trim ()))
                //        newName = item.FileName.Replace(@txtold1.Text.Trim(), @txtnew1.Text.Trim());

                //}

                //if (chk2.Checked && !string.IsNullOrEmpty(txtold2.Text.Trim()))
                //{
                //    if (item.FileName.Contains(@txtold2.Text.Trim()))
                //        newName = item.FileName.Replace(@txtold2.Text.Trim(), @txtnew2.Text.Trim());

                //}

                //if (chk3.Checked && !string.IsNullOrEmpty(txtold3.Text.Trim()))
                //{
                //    if (item.FileName.Contains(@txtold3.Text.Trim()))
                //        newName = item.FileName.Replace(@txtold3.Text.Trim(), @txtnew3.Text.Trim());

                //}

                //if (chk4.Checked && !string.IsNullOrEmpty(txtold4.Text.Trim()))
                //{
                //    if (item.FileName.Contains(@txtold4.Text.Trim()))
                //        newName = item.FileName.Replace(@txtold4.Text.Trim(), @txtnew4.Text.Trim());

                //}

                //if (chk5.Checked && !string.IsNullOrEmpty(txtold5.Text.Trim()))
                //{
                //    if (item.FileName.Contains(@txtold5.Text.Trim()))
                //        newName = item.FileName.Replace(@txtold5.Text.Trim(), @txtnew5.Text.Trim());

                //}



                if (!string.IsNullOrEmpty(newName) && (newName != item.FileName))
                {
                    try
                    {
                        if (File.Exists(item.FilePath))
                        {
                            i++;
                            this.Text = "正在处理第:" + i + "个文件";
                            File.Move(item.FilePath, item.FileDirectory + @"\" + newName);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("修改文件名出现错误," + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }

            MessageBox.Show("共计完成修改文件个数:" + i, "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Text = "批量修改文件名,Ver:" + Application.ProductVersion;
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





       



        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldname"></param>
        private string CheckFilesName(string oldname)
        {
            string newName = "";

            if (chk1.Checked && !string.IsNullOrEmpty(txtold1.Text.Trim()))
            {
                if (oldname.Contains(@txtold1.Text.Trim()))
                    newName = oldname.Replace(@txtold1.Text.Trim(), @txtnew1.Text.Trim());

            }

            if (chk2.Checked && !string.IsNullOrEmpty(txtold2.Text.Trim()))
            {
                if (oldname.Contains(@txtold2.Text.Trim()))
                    newName = oldname.Replace(@txtold2.Text.Trim(), @txtnew2.Text.Trim());

            }

            if (chk3.Checked && !string.IsNullOrEmpty(txtold3.Text.Trim()))
            {
                if (oldname.Contains(@txtold3.Text.Trim()))
                    newName = oldname.Replace(@txtold3.Text.Trim(), @txtnew3.Text.Trim());

            }

            if (chk4.Checked && !string.IsNullOrEmpty(txtold4.Text.Trim()))
            {
                if (oldname.Contains(@txtold4.Text.Trim()))
                    newName = oldname.Replace(@txtold4.Text.Trim(), @txtnew4.Text.Trim());

            }

            if (chk5.Checked && !string.IsNullOrEmpty(txtold5.Text.Trim()))
            {
                if (oldname.Contains(@txtold5.Text.Trim()))
                    newName = oldname.Replace(@txtold5.Text.Trim(), @txtnew5.Text.Trim());

            }

            return newName;
        }






        /// <summary>
        /// 
        /// </summary>
        public class DirectoryAllFiles
        {
            static List<FileInformation> FileList = new List<FileInformation>();
            public static List<FileInformation> GetAllFiles(DirectoryInfo dir)
            {
                FileInfo[] allFile = dir.GetFiles();
                foreach (FileInfo fi in allFile)
                {
                    FileList.Add(new FileInformation { FileName = fi.Name, FilePath = fi.FullName , FileDirectory  = fi.DirectoryName,FileExtension = fi.Extension });
                }
                DirectoryInfo[] allDir = dir.GetDirectories();
                foreach (DirectoryInfo d in allDir)
                {
                    GetAllFiles(d);
                }
                return FileList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public class FileInformation
        {
            public string FileName { get; set; }
            public string FilePath { get; set; }
            public string FileDirectory { get; set; }
            public string FileExtension{get;set;}
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="check"></param>
        /// <param name="txtold"></param>
        /// <param name="txtnew"></param>
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

        private void btnPreview_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFolder.Text.Trim()))
            {
                txtFolder.Focus();
                return;
            }

            if (!Directory.Exists(txtFolder.Text.Trim()))
            {
                MessageBox.Show("文件夹地址不存在,请重新输入", "文件夹不存在", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtFolder.SelectAll();
                txtFolder.Focus();
                return;
            }

            if (!this.bgwPreview.IsBusy)
            {
                bgwPreview.RunWorkerAsync();
            }

        }




        private void PreviewFiles()
        {
            this.Invoke((EventHandler)(delegate
            {

                txtFolder.Enabled = false;
                txtAddExtension.Enabled = false;
                btnGo.Enabled = false;
                btnPreview.Enabled = false;
                btnAddExtension.Enabled = false;
                btnDeleteExtension.Enabled = false;
                btnSelectAllExtension.Enabled = false;
                btnSelectNotAllExtension.Enabled = false;
                chkIncludeFolders.Enabled = false;
                
                lstViewFileInfoView.Items.Clear();
                chklstExtension.Items.Clear();
                int filesCount = 0;

                if (chkIncludeFolders.Checked)
                {
                    List<FileInformation> list = new List<FileInformation>();
                    list = DirectoryAllFiles.GetAllFiles(new System.IO.DirectoryInfo(@txtFolder.Text.Trim()));

                    foreach (var item in list)
                    {
                        if (!chklstExtension.Items.Contains(item.FileExtension.ToLower())) //不存在,添加
                            chklstExtension.Items.Add(item.FileExtension.ToLower());
                        filesCount++;
                        AddItem2ListView(lstViewFileInfoView, filesCount, item.FileExtension, item.FileName, "", item.FileDirectory);
                    }


                }
                else
                {

                    DirectoryInfo di = new DirectoryInfo(txtFolder.Text.Trim());
                    FileInfo[] fis = di.GetFiles();
                    foreach (FileInfo fi in fis)
                    {
                        if (!chklstExtension.Items.Contains(fi.Extension.ToLower())) //不存在,添加
                            chklstExtension.Items.Add(fi.Extension);
                        filesCount++;
                        AddItem2ListView(lstViewFileInfoView, filesCount, fi.Extension, fi.Name, "", fi.DirectoryName);

                    }
                }
            }));

        }




        private void AddItem2ListView(ListView listview,int filescount,string fileextension,string oldname,string newname,string filefolder)
        {
            //listview.Items.Clear();
            listview.BeginUpdate();//数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度 
            ListViewItem lt = new ListViewItem();
            lt = lstViewFileInfoView.Items.Add(filescount.ToString());
            lt.SubItems.Add(fileextension.ToLower ());
            lt.SubItems.Add(oldname );
            lt.SubItems.Add(newname );
            lt.SubItems.Add(filefolder);
            listview.EndUpdate();//结束数据处理，UI界面一次性绘制。
            
                    
        }


        private void btnSelectNotAllExtension_Click(object sender, EventArgs e)
        {
            if (chklstExtension.Items.Count > 0)
            {
                for (int i = 0; i < chklstExtension.Items.Count; i++)
                {
                    if (chklstExtension.GetItemChecked(i))
                    {
                        chklstExtension.SetItemChecked(i, false);
                        if (lstExtension.Items.Contains(chklstExtension.Items[i]))
                            lstExtension.Items.Remove (chklstExtension.Items[i]);

                    }
                    else
                    {
                        chklstExtension.SetItemChecked(i, true);
                        if (!lstExtension.Items.Contains(chklstExtension.Items[i]))
                            lstExtension.Items.Add(chklstExtension.Items[i]);

                    }
                }

            }
        }

        private void btnSelectAllExtension_Click(object sender, EventArgs e)
        {
            if (chklstExtension.Items.Count > 0)
            {
                for (int i = 0; i < chklstExtension.Items.Count; i++)
                {
                    chklstExtension.SetItemChecked(i, true);  
                    if (!lstExtension.Items.Contains (chklstExtension.Items[i]))
                        lstExtension.Items.Add (chklstExtension.Items[i]);



                }

            }
        }




        private void btnAddExtension_Click(object sender, EventArgs e)
        {
            AddExtesnion();

        }


        /// <summary>
        /// 
        /// </summary>
        private void AddExtesnion()
        {
            if (string.IsNullOrEmpty(txtAddExtension.Text.Trim()))
            {
                txtAddExtension.Focus();
                return;
            }
            if (txtAddExtension.Text.Trim().StartsWith("."))
            {
                if (!lstExtension.Items.Contains(txtAddExtension.Text.Trim().ToLower()))
                {
                    lstExtension.Items.Add(txtAddExtension.Text.Trim().ToLower());
                    txtAddExtension.SelectAll();
                   
                }
            }
            else
            {
                MessageBox.Show("扩展名格式错误,请重新输入.", "格式错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddExtension.SelectAll();
                txtAddExtension.Focus();
            }
        }


        private void txtAddExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                AddExtesnion();
            }
        }

        private void lstExtension_DoubleClick(object sender, EventArgs e)
        {
            if (lstExtension.Items.Count > 0)
                lstExtension.Items.RemoveAt(lstExtension.SelectedIndex);
        }

        private void lstViewFileInfoView_DoubleClick(object sender, EventArgs e)
        {
            string fileFolder = lstViewFileInfoView.SelectedItems[0].SubItems[4].Text;
            if (!string.IsNullOrEmpty (fileFolder ))
                System.Diagnostics.Process.Start(@fileFolder);


           
        }

        private void btnDeleteExtension_Click(object sender, EventArgs e)
        {
            if (lstExtension.Items.Count > 0)
                lstExtension.Items.RemoveAt(lstExtension.SelectedIndex);
        }

        private void bgwPreview_DoWork(object sender, DoWorkEventArgs e)
        {
            PreviewFiles();
        }

        private void bgwPreview_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtFolder.Enabled = true;
            txtAddExtension.Enabled = true;
            btnGo.Enabled = true;
            btnPreview.Enabled = true;
            btnAddExtension.Enabled = true;
            btnDeleteExtension.Enabled = true;
            btnSelectAllExtension.Enabled = true;
            btnSelectNotAllExtension.Enabled = true;
            chkIncludeFolders.Enabled = true;
            MessageBox.Show("文件预览完毕.","Complete",MessageBoxButtons.OK,MessageBoxIcon.Information );
        }

    }
}