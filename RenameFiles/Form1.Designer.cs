namespace RenameFiles
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnGo = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIncludeFolders = new System.Windows.Forms.CheckBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.grbSetting = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnew5 = new System.Windows.Forms.TextBox();
            this.txtold5 = new System.Windows.Forms.TextBox();
            this.txtnew4 = new System.Windows.Forms.TextBox();
            this.txtold4 = new System.Windows.Forms.TextBox();
            this.txtnew3 = new System.Windows.Forms.TextBox();
            this.txtold3 = new System.Windows.Forms.TextBox();
            this.txtnew2 = new System.Windows.Forms.TextBox();
            this.txtold2 = new System.Windows.Forms.TextBox();
            this.txtnew1 = new System.Windows.Forms.TextBox();
            this.txtold1 = new System.Windows.Forms.TextBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.lstViewFileInfoView = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectNotAllExtension = new System.Windows.Forms.Button();
            this.btnSelectAllExtension = new System.Windows.Forms.Button();
            this.chklstExtension = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteExtension = new System.Windows.Forms.Button();
            this.btnAddExtension = new System.Windows.Forms.Button();
            this.txtAddExtension = new System.Windows.Forms.TextBox();
            this.lstExtension = new System.Windows.Forms.ListBox();
            this.bgwPreview = new System.ComponentModel.BackgroundWorker();
            this.bgwRenameFiles = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.grbSetting.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(361, 15);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(76, 30);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "开始改名";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(82, 21);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(265, 21);
            this.txtFolder.TabIndex = 1;
            this.txtFolder.Click += new System.EventHandler(this.txtFolder_Click);
            this.txtFolder.DoubleClick += new System.EventHandler(this.txtFolder_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件夹地址";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIncludeFolders);
            this.groupBox1.Controls.Add(this.btnPreview);
            this.groupBox1.Controls.Add(this.txtFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主目录选择";
            // 
            // chkIncludeFolders
            // 
            this.chkIncludeFolders.AutoSize = true;
            this.chkIncludeFolders.Checked = true;
            this.chkIncludeFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeFolders.Location = new System.Drawing.Point(17, 59);
            this.chkIncludeFolders.Name = "chkIncludeFolders";
            this.chkIncludeFolders.Size = new System.Drawing.Size(96, 16);
            this.chkIncludeFolders.TabIndex = 4;
            this.chkIncludeFolders.Text = "包含子文件夹";
            this.chkIncludeFolders.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(360, 51);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(76, 30);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "预览文件";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // grbSetting
            // 
            this.grbSetting.Controls.Add(this.label5);
            this.grbSetting.Controls.Add(this.label4);
            this.grbSetting.Controls.Add(this.label3);
            this.grbSetting.Controls.Add(this.txtnew5);
            this.grbSetting.Controls.Add(this.txtold5);
            this.grbSetting.Controls.Add(this.txtnew4);
            this.grbSetting.Controls.Add(this.txtold4);
            this.grbSetting.Controls.Add(this.txtnew3);
            this.grbSetting.Controls.Add(this.txtold3);
            this.grbSetting.Controls.Add(this.txtnew2);
            this.grbSetting.Controls.Add(this.txtold2);
            this.grbSetting.Controls.Add(this.txtnew1);
            this.grbSetting.Controls.Add(this.txtold1);
            this.grbSetting.Controls.Add(this.chk5);
            this.grbSetting.Controls.Add(this.chk4);
            this.grbSetting.Controls.Add(this.chk3);
            this.grbSetting.Controls.Add(this.chk2);
            this.grbSetting.Controls.Add(this.chk1);
            this.grbSetting.Location = new System.Drawing.Point(12, 132);
            this.grbSetting.Name = "grbSetting";
            this.grbSetting.Size = new System.Drawing.Size(451, 200);
            this.grbSetting.TabIndex = 5;
            this.grbSetting.TabStop = false;
            this.grbSetting.Text = "条件设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "新字符串";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "旧字符串";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "勾选条件";
            // 
            // txtnew5
            // 
            this.txtnew5.Location = new System.Drawing.Point(294, 160);
            this.txtnew5.Name = "txtnew5";
            this.txtnew5.Size = new System.Drawing.Size(139, 21);
            this.txtnew5.TabIndex = 14;
            this.txtnew5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtold5
            // 
            this.txtold5.Location = new System.Drawing.Point(115, 160);
            this.txtold5.Name = "txtold5";
            this.txtold5.Size = new System.Drawing.Size(126, 21);
            this.txtold5.TabIndex = 13;
            this.txtold5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnew4
            // 
            this.txtnew4.Location = new System.Drawing.Point(294, 130);
            this.txtnew4.Name = "txtnew4";
            this.txtnew4.Size = new System.Drawing.Size(139, 21);
            this.txtnew4.TabIndex = 12;
            this.txtnew4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtold4
            // 
            this.txtold4.Location = new System.Drawing.Point(115, 131);
            this.txtold4.Name = "txtold4";
            this.txtold4.Size = new System.Drawing.Size(126, 21);
            this.txtold4.TabIndex = 11;
            this.txtold4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnew3
            // 
            this.txtnew3.Location = new System.Drawing.Point(294, 102);
            this.txtnew3.Name = "txtnew3";
            this.txtnew3.Size = new System.Drawing.Size(139, 21);
            this.txtnew3.TabIndex = 10;
            this.txtnew3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtold3
            // 
            this.txtold3.Location = new System.Drawing.Point(115, 101);
            this.txtold3.Name = "txtold3";
            this.txtold3.Size = new System.Drawing.Size(126, 21);
            this.txtold3.TabIndex = 9;
            this.txtold3.Text = "_HDA00N_";
            this.txtold3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnew2
            // 
            this.txtnew2.Location = new System.Drawing.Point(294, 74);
            this.txtnew2.Name = "txtnew2";
            this.txtnew2.Size = new System.Drawing.Size(139, 21);
            this.txtnew2.TabIndex = 8;
            this.txtnew2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtold2
            // 
            this.txtold2.Location = new System.Drawing.Point(115, 73);
            this.txtold2.Name = "txtold2";
            this.txtold2.Size = new System.Drawing.Size(126, 21);
            this.txtold2.TabIndex = 7;
            this.txtold2.Text = "联网更新";
            this.txtold2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnew1
            // 
            this.txtnew1.Location = new System.Drawing.Point(294, 47);
            this.txtnew1.Name = "txtnew1";
            this.txtnew1.Size = new System.Drawing.Size(139, 21);
            this.txtnew1.TabIndex = 6;
            this.txtnew1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtold1
            // 
            this.txtold1.Location = new System.Drawing.Point(115, 47);
            this.txtold1.Name = "txtold1";
            this.txtold1.Size = new System.Drawing.Size(126, 21);
            this.txtold1.TabIndex = 5;
            this.txtold1.Text = "-";
            this.txtold1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(17, 163);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(54, 16);
            this.chk5.TabIndex = 4;
            this.chk5.Text = "条件5";
            this.chk5.UseVisualStyleBackColor = true;
            this.chk5.CheckedChanged += new System.EventHandler(this.chk5_CheckedChanged);
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(17, 131);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(54, 16);
            this.chk4.TabIndex = 3;
            this.chk4.Text = "条件4";
            this.chk4.UseVisualStyleBackColor = true;
            this.chk4.CheckedChanged += new System.EventHandler(this.chk4_CheckedChanged);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Checked = true;
            this.chk3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk3.Location = new System.Drawing.Point(17, 103);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(54, 16);
            this.chk3.TabIndex = 2;
            this.chk3.Text = "条件3";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.chk3_CheckedChanged);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Checked = true;
            this.chk2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk2.Location = new System.Drawing.Point(17, 75);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(54, 16);
            this.chk2.TabIndex = 1;
            this.chk2.Text = "条件2";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.chk2_CheckedChanged);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Checked = true;
            this.chk1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk1.Location = new System.Drawing.Point(17, 47);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(54, 16);
            this.chk1.TabIndex = 0;
            this.chk1.Text = "条件1";
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // lstViewFileInfoView
            // 
            this.lstViewFileInfoView.Location = new System.Drawing.Point(469, 44);
            this.lstViewFileInfoView.Name = "lstViewFileInfoView";
            this.lstViewFileInfoView.Size = new System.Drawing.Size(763, 552);
            this.lstViewFileInfoView.TabIndex = 6;
            this.lstViewFileInfoView.UseCompatibleStateImageBehavior = false;
            this.lstViewFileInfoView.DoubleClick += new System.EventHandler(this.lstViewFileInfoView_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectNotAllExtension);
            this.groupBox2.Controls.Add(this.btnSelectAllExtension);
            this.groupBox2.Controls.Add(this.chklstExtension);
            this.groupBox2.Location = new System.Drawing.Point(12, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 258);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "预览文件类型列表";
            // 
            // btnSelectNotAllExtension
            // 
            this.btnSelectNotAllExtension.Location = new System.Drawing.Point(96, 212);
            this.btnSelectNotAllExtension.Name = "btnSelectNotAllExtension";
            this.btnSelectNotAllExtension.Size = new System.Drawing.Size(75, 30);
            this.btnSelectNotAllExtension.TabIndex = 7;
            this.btnSelectNotAllExtension.Text = "反选";
            this.btnSelectNotAllExtension.UseVisualStyleBackColor = true;
            this.btnSelectNotAllExtension.Click += new System.EventHandler(this.btnSelectNotAllExtension_Click);
            // 
            // btnSelectAllExtension
            // 
            this.btnSelectAllExtension.Location = new System.Drawing.Point(11, 212);
            this.btnSelectAllExtension.Name = "btnSelectAllExtension";
            this.btnSelectAllExtension.Size = new System.Drawing.Size(75, 30);
            this.btnSelectAllExtension.TabIndex = 7;
            this.btnSelectAllExtension.Text = "全选";
            this.btnSelectAllExtension.UseVisualStyleBackColor = true;
            this.btnSelectAllExtension.Click += new System.EventHandler(this.btnSelectAllExtension_Click);
            // 
            // chklstExtension
            // 
            this.chklstExtension.FormattingEnabled = true;
            this.chklstExtension.Location = new System.Drawing.Point(19, 26);
            this.chklstExtension.Name = "chklstExtension";
            this.chklstExtension.Size = new System.Drawing.Size(146, 180);
            this.chklstExtension.TabIndex = 0;
            this.chklstExtension.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstExtension_ItemCheck);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnDeleteExtension);
            this.groupBox3.Controls.Add(this.btnAddExtension);
            this.groupBox3.Controls.Add(this.txtAddExtension);
            this.groupBox3.Controls.Add(this.lstExtension);
            this.groupBox3.Location = new System.Drawing.Point(202, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 258);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "更名文件类型列表";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "注意:若不选定扩展名,则修改所有文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "输入扩展名";
            // 
            // btnDeleteExtension
            // 
            this.btnDeleteExtension.Location = new System.Drawing.Point(148, 119);
            this.btnDeleteExtension.Name = "btnDeleteExtension";
            this.btnDeleteExtension.Size = new System.Drawing.Size(76, 30);
            this.btnDeleteExtension.TabIndex = 5;
            this.btnDeleteExtension.Text = "删除";
            this.btnDeleteExtension.UseVisualStyleBackColor = true;
            this.btnDeleteExtension.Click += new System.EventHandler(this.btnDeleteExtension_Click);
            // 
            // btnAddExtension
            // 
            this.btnAddExtension.Location = new System.Drawing.Point(148, 83);
            this.btnAddExtension.Name = "btnAddExtension";
            this.btnAddExtension.Size = new System.Drawing.Size(76, 30);
            this.btnAddExtension.TabIndex = 4;
            this.btnAddExtension.Text = "添加";
            this.btnAddExtension.UseVisualStyleBackColor = true;
            this.btnAddExtension.Click += new System.EventHandler(this.btnAddExtension_Click);
            // 
            // txtAddExtension
            // 
            this.txtAddExtension.Location = new System.Drawing.Point(135, 47);
            this.txtAddExtension.Name = "txtAddExtension";
            this.txtAddExtension.Size = new System.Drawing.Size(114, 21);
            this.txtAddExtension.TabIndex = 1;
            this.txtAddExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddExtension_KeyPress);
            // 
            // lstExtension
            // 
            this.lstExtension.FormattingEnabled = true;
            this.lstExtension.ItemHeight = 12;
            this.lstExtension.Location = new System.Drawing.Point(6, 26);
            this.lstExtension.Name = "lstExtension";
            this.lstExtension.Size = new System.Drawing.Size(120, 184);
            this.lstExtension.TabIndex = 0;
            this.lstExtension.DoubleClick += new System.EventHandler(this.lstExtension_DoubleClick);
            // 
            // bgwPreview
            // 
            this.bgwPreview.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwPreview_DoWork);
            this.bgwPreview.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwPreview_RunWorkerCompleted);
            // 
            // bgwRenameFiles
            // 
            this.bgwRenameFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRenameFiles_DoWork);
            this.bgwRenameFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwRenameFiles_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1244, 606);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstViewFileInfoView);
            this.Controls.Add(this.grbSetting);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbSetting.ResumeLayout(false);
            this.grbSetting.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbSetting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnew5;
        private System.Windows.Forms.TextBox txtold5;
        private System.Windows.Forms.TextBox txtnew4;
        private System.Windows.Forms.TextBox txtold4;
        private System.Windows.Forms.TextBox txtnew3;
        private System.Windows.Forms.TextBox txtold3;
        private System.Windows.Forms.TextBox txtnew2;
        private System.Windows.Forms.TextBox txtold2;
        private System.Windows.Forms.TextBox txtnew1;
        private System.Windows.Forms.TextBox txtold1;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.ListView lstViewFileInfoView;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox chklstExtension;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteExtension;
        private System.Windows.Forms.Button btnAddExtension;
        private System.Windows.Forms.TextBox txtAddExtension;
        private System.Windows.Forms.ListBox lstExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIncludeFolders;
        private System.Windows.Forms.Button btnSelectNotAllExtension;
        private System.Windows.Forms.Button btnSelectAllExtension;
        private System.ComponentModel.BackgroundWorker bgwPreview;
        private System.ComponentModel.BackgroundWorker bgwRenameFiles;
        private System.Windows.Forms.Label label6;
    }
}

