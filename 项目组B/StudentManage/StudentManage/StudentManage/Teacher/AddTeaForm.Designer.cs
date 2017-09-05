namespace StudentManage.Teacher
{
    partial class AddTeaForm
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
            this.lblTeaNo = new System.Windows.Forms.Label();
            this.txtTeaNo = new System.Windows.Forms.TextBox();
            this.cmbRank = new System.Windows.Forms.ComboBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtTeaName = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.rabMan = new System.Windows.Forms.RadioButton();
            this.rabWoman = new System.Windows.Forms.RadioButton();
            this.lblDegree = new System.Windows.Forms.Label();
            this.cmbDegree = new System.Windows.Forms.ComboBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(79, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保　存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTeaNo
            // 
            this.lblTeaNo.AutoSize = true;
            this.lblTeaNo.Location = new System.Drawing.Point(40, 35);
            this.lblTeaNo.Name = "lblTeaNo";
            this.lblTeaNo.Size = new System.Drawing.Size(53, 12);
            this.lblTeaNo.TabIndex = 1;
            this.lblTeaNo.Text = "教师编号";
            // 
            // txtTeaNo
            // 
            this.txtTeaNo.Location = new System.Drawing.Point(110, 31);
            this.txtTeaNo.MaxLength = 12;
            this.txtTeaNo.Name = "txtTeaNo";
            this.txtTeaNo.Size = new System.Drawing.Size(85, 21);
            this.txtTeaNo.TabIndex = 2;
            this.txtTeaNo.Text = "1002";
            // 
            // cmbRank
            // 
            this.cmbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRank.FormattingEnabled = true;
            this.cmbRank.Items.AddRange(new object[] {
            "助教",
            "讲师",
            "副教授",
            "教授",
            "其他"});
            this.cmbRank.Location = new System.Drawing.Point(110, 164);
            this.cmbRank.Name = "cmbRank";
            this.cmbRank.Size = new System.Drawing.Size(104, 20);
            this.cmbRank.TabIndex = 3;
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(40, 79);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(53, 12);
            this.lblStuName.TabIndex = 4;
            this.lblStuName.Text = "姓　　名";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(42, 123);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(53, 12);
            this.lblBirthday.TabIndex = 5;
            this.lblBirthday.Text = "年　　龄";
            // 
            // txtTeaName
            // 
            this.txtTeaName.Location = new System.Drawing.Point(110, 74);
            this.txtTeaName.MaxLength = 5;
            this.txtTeaName.Name = "txtTeaName";
            this.txtTeaName.Size = new System.Drawing.Size(85, 21);
            this.txtTeaName.TabIndex = 7;
            this.txtTeaName.Text = "李梓";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(42, 166);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(53, 12);
            this.lblRank.TabIndex = 8;
            this.lblRank.Text = "职　　称";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(110, 247);
            this.txtRemark.MaxLength = 25;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(233, 88);
            this.txtRemark.TabIndex = 9;
            this.txtRemark.Text = "生前何必久睡,死后自会长眠!!!";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(42, 250);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(53, 12);
            this.lblRemark.TabIndex = 10;
            this.lblRemark.Text = "备　　注";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(244, 84);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(53, 12);
            this.lblSex.TabIndex = 11;
            this.lblSex.Text = "性　　别";
            // 
            // rabMan
            // 
            this.rabMan.AutoSize = true;
            this.rabMan.Checked = true;
            this.rabMan.Location = new System.Drawing.Point(308, 83);
            this.rabMan.Name = "rabMan";
            this.rabMan.Size = new System.Drawing.Size(35, 16);
            this.rabMan.TabIndex = 12;
            this.rabMan.TabStop = true;
            this.rabMan.Text = "男";
            this.rabMan.UseVisualStyleBackColor = true;
            // 
            // rabWoman
            // 
            this.rabWoman.AutoSize = true;
            this.rabWoman.Location = new System.Drawing.Point(353, 83);
            this.rabWoman.Name = "rabWoman";
            this.rabWoman.Size = new System.Drawing.Size(35, 16);
            this.rabWoman.TabIndex = 13;
            this.rabWoman.Text = "女";
            this.rabWoman.UseVisualStyleBackColor = true;
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(244, 127);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(53, 12);
            this.lblDegree.TabIndex = 14;
            this.lblDegree.Text = "学　　历";
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
            "博士后",
            "其他"});
            this.cmbDegree.Location = new System.Drawing.Point(303, 123);
            this.cmbDegree.Name = "cmbDegree";
            this.cmbDegree.Size = new System.Drawing.Size(102, 20);
            this.cmbDegree.TabIndex = 15;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(244, 167);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(53, 12);
            this.lblTel.TabIndex = 16;
            this.lblTel.Text = "联系电话";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(303, 163);
            this.txtTel.MaxLength = 12;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(99, 21);
            this.txtTel.TabIndex = 17;
            this.txtTel.Text = "8008208820";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(268, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "取　消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(42, 209);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(53, 12);
            this.lblAdress.TabIndex = 19;
            this.lblAdress.Text = "住　　址";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 206);
            this.txtAddress.MaxLength = 20;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(233, 21);
            this.txtAddress.TabIndex = 25;
            this.txtAddress.Text = "浙江省杭州市";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(110, 118);
            this.nudAge.Name = "nudAge";
            this.nudAge.ReadOnly = true;
            this.nudAge.Size = new System.Drawing.Size(56, 21);
            this.nudAge.TabIndex = 21;
            this.nudAge.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // AddTeaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 409);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.cmbDegree);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.rabWoman);
            this.Controls.Add(this.rabMan);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.txtTeaName);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.cmbRank);
            this.Controls.Add(this.txtTeaNo);
            this.Controls.Add(this.lblTeaNo);
            this.Controls.Add(this.btnSave);
            this.Name = "AddTeaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加教师";
            this.Load += new System.EventHandler(this.AddTeaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTeaNo;
        private System.Windows.Forms.TextBox txtTeaNo;
        private System.Windows.Forms.ComboBox cmbRank;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox txtTeaName;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.RadioButton rabMan;
        private System.Windows.Forms.RadioButton rabWoman;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.ComboBox cmbDegree;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.NumericUpDown nudAge;
    }
}