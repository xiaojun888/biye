namespace StudentManage.Teacher
{
    partial class ModifyTeaForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbRank = new System.Windows.Forms.ComboBox();
            this.lblTeaNo = new System.Windows.Forms.Label();
            this.txtTeaNo = new System.Windows.Forms.TextBox();
            this.txtTeaName = new System.Windows.Forms.TextBox();
            this.lblTeaName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.rdbWoman = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDegree = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保　存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbRank
            // 
            this.cmbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRank.FormattingEnabled = true;
            this.cmbRank.Items.AddRange(new object[] {
            "助教",
            "讲师",
            "副教授",
            "教授"});
            this.cmbRank.Location = new System.Drawing.Point(95, 165);
            this.cmbRank.Name = "cmbRank";
            this.cmbRank.Size = new System.Drawing.Size(105, 20);
            this.cmbRank.TabIndex = 2;
            // 
            // lblTeaNo
            // 
            this.lblTeaNo.AutoSize = true;
            this.lblTeaNo.Location = new System.Drawing.Point(31, 35);
            this.lblTeaNo.Name = "lblTeaNo";
            this.lblTeaNo.Size = new System.Drawing.Size(53, 12);
            this.lblTeaNo.TabIndex = 3;
            this.lblTeaNo.Text = "教师编号";
            // 
            // txtTeaNo
            // 
            this.txtTeaNo.Location = new System.Drawing.Point(95, 30);
            this.txtTeaNo.MaxLength = 12;
            this.txtTeaNo.Name = "txtTeaNo";
            this.txtTeaNo.Size = new System.Drawing.Size(77, 21);
            this.txtTeaNo.TabIndex = 4;
            // 
            // txtTeaName
            // 
            this.txtTeaName.Location = new System.Drawing.Point(95, 78);
            this.txtTeaName.MaxLength = 5;
            this.txtTeaName.Name = "txtTeaName";
            this.txtTeaName.Size = new System.Drawing.Size(77, 21);
            this.txtTeaName.TabIndex = 5;
            // 
            // lblTeaName
            // 
            this.lblTeaName.AutoSize = true;
            this.lblTeaName.Location = new System.Drawing.Point(30, 82);
            this.lblTeaName.Name = "lblTeaName";
            this.lblTeaName.Size = new System.Drawing.Size(53, 12);
            this.lblTeaName.TabIndex = 6;
            this.lblTeaName.Text = "姓　　名";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(30, 128);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(53, 12);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "年　　龄";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "联系电话";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "备　　注";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "性　　别";
            // 
            // rdbMan
            // 
            this.rdbMan.AutoSize = true;
            this.rdbMan.Checked = true;
            this.rdbMan.Location = new System.Drawing.Point(288, 83);
            this.rdbMan.Name = "rdbMan";
            this.rdbMan.Size = new System.Drawing.Size(35, 16);
            this.rdbMan.TabIndex = 11;
            this.rdbMan.TabStop = true;
            this.rdbMan.Text = "男";
            this.rdbMan.UseVisualStyleBackColor = true;
            // 
            // rdbWoman
            // 
            this.rdbWoman.AutoSize = true;
            this.rdbWoman.Location = new System.Drawing.Point(335, 83);
            this.rdbWoman.Name = "rdbWoman";
            this.rdbWoman.Size = new System.Drawing.Size(35, 16);
            this.rdbWoman.TabIndex = 12;
            this.rdbWoman.Text = "女";
            this.rdbWoman.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "职　　称";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(95, 123);
            this.nudAge.Name = "nudAge";
            this.nudAge.ReadOnly = true;
            this.nudAge.Size = new System.Drawing.Size(54, 21);
            this.nudAge.TabIndex = 14;
            this.nudAge.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "学　　历";
            // 
            // cmbDegree
            // 
            this.cmbDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDegree.FormattingEnabled = true;
            this.cmbDegree.Items.AddRange(new object[] {
            "专科",
            "本科",
            "研究生",
            "博士",
            "博士后"});
            this.cmbDegree.Location = new System.Drawing.Point(286, 123);
            this.cmbDegree.Name = "cmbDegree";
            this.cmbDegree.Size = new System.Drawing.Size(96, 20);
            this.cmbDegree.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "住　　址";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(286, 166);
            this.txtTel.MaxLength = 12;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(96, 21);
            this.txtTel.TabIndex = 18;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(95, 206);
            this.txtAddress.MaxLength = 20;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(205, 21);
            this.txtAddress.TabIndex = 19;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(95, 251);
            this.txtRemark.MaxLength = 25;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(236, 75);
            this.txtRemark.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(239, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "取　消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ModifyTeaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 391);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbDegree);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdbWoman);
            this.Controls.Add(this.rdbMan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblTeaName);
            this.Controls.Add(this.txtTeaName);
            this.Controls.Add(this.txtTeaNo);
            this.Controls.Add(this.lblTeaNo);
            this.Controls.Add(this.cmbRank);
            this.Controls.Add(this.btnSave);
            this.Name = "ModifyTeaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改教师信息";
            this.Load += new System.EventHandler(this.ModifyTeaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbRank;
        private System.Windows.Forms.Label lblTeaNo;
        private System.Windows.Forms.TextBox txtTeaNo;
        private System.Windows.Forms.TextBox txtTeaName;
        private System.Windows.Forms.Label lblTeaName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbMan;
        private System.Windows.Forms.RadioButton rdbWoman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDegree;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnCancel;
    }
}