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
            this.btnGo = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.txtold1 = new System.Windows.Forms.TextBox();
            this.txtnew1 = new System.Windows.Forms.TextBox();
            this.txtold2 = new System.Windows.Forms.TextBox();
            this.txtnew2 = new System.Windows.Forms.TextBox();
            this.txtnew3 = new System.Windows.Forms.TextBox();
            this.txtold3 = new System.Windows.Forms.TextBox();
            this.txtnew4 = new System.Windows.Forms.TextBox();
            this.txtold4 = new System.Windows.Forms.TextBox();
            this.txtnew5 = new System.Windows.Forms.TextBox();
            this.txtold5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(357, 25);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(76, 30);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(86, 31);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(265, 21);
            this.txtFolder.TabIndex = 1;
            this.txtFolder.Click += new System.EventHandler(this.txtFolder_Click);
            this.txtFolder.DoubleClick += new System.EventHandler(this.txtFolder_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件夹地址";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "功能:删除执法仪视频文件名称中的\"-\"和\"联网更新\"";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtnew5);
            this.groupBox2.Controls.Add(this.txtold5);
            this.groupBox2.Controls.Add(this.txtnew4);
            this.groupBox2.Controls.Add(this.txtold4);
            this.groupBox2.Controls.Add(this.txtnew3);
            this.groupBox2.Controls.Add(this.txtold3);
            this.groupBox2.Controls.Add(this.txtnew2);
            this.groupBox2.Controls.Add(this.txtold2);
            this.groupBox2.Controls.Add(this.txtnew1);
            this.groupBox2.Controls.Add(this.txtold1);
            this.groupBox2.Controls.Add(this.chk5);
            this.groupBox2.Controls.Add(this.chk4);
            this.groupBox2.Controls.Add(this.chk3);
            this.groupBox2.Controls.Add(this.chk2);
            this.groupBox2.Controls.Add(this.chk1);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 200);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "条件设置";
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
            // txtold1
            // 
            this.txtold1.Location = new System.Drawing.Point(115, 47);
            this.txtold1.Name = "txtold1";
            this.txtold1.Size = new System.Drawing.Size(126, 21);
            this.txtold1.TabIndex = 5;
            this.txtold1.Text = "-";
            this.txtold1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnew1
            // 
            this.txtnew1.Location = new System.Drawing.Point(294, 47);
            this.txtnew1.Name = "txtnew1";
            this.txtnew1.Size = new System.Drawing.Size(139, 21);
            this.txtnew1.TabIndex = 6;
            this.txtnew1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txtnew2
            // 
            this.txtnew2.Location = new System.Drawing.Point(294, 74);
            this.txtnew2.Name = "txtnew2";
            this.txtnew2.Size = new System.Drawing.Size(139, 21);
            this.txtnew2.TabIndex = 8;
            this.txtnew2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "勾选条件";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "新字符串";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 319);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}

