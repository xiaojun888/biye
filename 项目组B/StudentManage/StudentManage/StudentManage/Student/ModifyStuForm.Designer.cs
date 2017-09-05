namespace StudentManage.Student
{
    partial class ModifyStuForm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEntranceTime = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cmbClassId = new System.Windows.Forms.ComboBox();
            this.rabWoman = new System.Windows.Forms.RadioButton();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtStuTel = new System.Windows.Forms.TextBox();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblStuAddress = new System.Windows.Forms.Label();
            this.lblStuTel = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblStuNo = new System.Windows.Forms.Label();
            this.lblStuSex = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblEntranceTime = new System.Windows.Forms.Label();
            this.lblStuId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rabMan = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(221, 370);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 88;
            this.btnReset.Text = "重　置";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(41, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 14);
            this.label4.TabIndex = 87;
            this.label4.Text = "友情提示：*为必填项，请确认后提交";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(255, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 14);
            this.label3.TabIndex = 86;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(479, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 14);
            this.label2.TabIndex = 85;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(256, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 84;
            this.label1.Text = "*";
            // 
            // dtpEntranceTime
            // 
            this.dtpEntranceTime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpEntranceTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntranceTime.Location = new System.Drawing.Point(344, 135);
            this.dtpEntranceTime.Name = "dtpEntranceTime";
            this.dtpEntranceTime.Size = new System.Drawing.Size(128, 23);
            this.dtpEntranceTime.TabIndex = 83;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(344, 93);
            this.dtpBirthDate.MaxDate = new System.DateTime(8965, 8, 18, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(128, 23);
            this.dtpBirthDate.TabIndex = 82;
            this.dtpBirthDate.Value = new System.DateTime(1980, 8, 18, 0, 0, 0, 0);
            // 
            // cmbClassId
            // 
            this.cmbClassId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbClassId.FormattingEnabled = true;
            this.cmbClassId.Location = new System.Drawing.Point(344, 52);
            this.cmbClassId.Name = "cmbClassId";
            this.cmbClassId.Size = new System.Drawing.Size(128, 22);
            this.cmbClassId.TabIndex = 81;
            // 
            // rabWoman
            // 
            this.rabWoman.AutoSize = true;
            this.rabWoman.BackColor = System.Drawing.Color.Transparent;
            this.rabWoman.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabWoman.Location = new System.Drawing.Point(203, 98);
            this.rabWoman.Name = "rabWoman";
            this.rabWoman.Size = new System.Drawing.Size(39, 18);
            this.rabWoman.TabIndex = 80;
            this.rabWoman.Text = "女";
            this.rabWoman.UseVisualStyleBackColor = false;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRemark.Location = new System.Drawing.Point(114, 231);
            this.txtRemark.MaxLength = 60;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(331, 78);
            this.txtRemark.TabIndex = 79;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.Location = new System.Drawing.Point(114, 185);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(331, 23);
            this.txtAddress.TabIndex = 78;
            // 
            // txtStuTel
            // 
            this.txtStuTel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStuTel.Location = new System.Drawing.Point(114, 136);
            this.txtStuTel.MaxLength = 12;
            this.txtStuTel.Name = "txtStuTel";
            this.txtStuTel.Size = new System.Drawing.Size(128, 23);
            this.txtStuTel.TabIndex = 77;
            // 
            // txtStuNo
            // 
            this.txtStuNo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStuNo.Location = new System.Drawing.Point(114, 13);
            this.txtStuNo.MaxLength = 10;
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.Size = new System.Drawing.Size(126, 23);
            this.txtStuNo.TabIndex = 76;
            // 
            // txtStuName
            // 
            this.txtStuName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStuName.Location = new System.Drawing.Point(114, 55);
            this.txtStuName.MaxLength = 4;
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(126, 23);
            this.txtStuName.TabIndex = 75;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.Transparent;
            this.lblClass.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClass.Location = new System.Drawing.Point(275, 58);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(63, 14);
            this.lblClass.TabIndex = 74;
            this.lblClass.Text = "所在班级";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.BackColor = System.Drawing.Color.Transparent;
            this.lblRemark.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRemark.Location = new System.Drawing.Point(41, 252);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(49, 14);
            this.lblRemark.TabIndex = 73;
            this.lblRemark.Text = "备  注";
            // 
            // lblStuAddress
            // 
            this.lblStuAddress.AutoSize = true;
            this.lblStuAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblStuAddress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuAddress.Location = new System.Drawing.Point(41, 185);
            this.lblStuAddress.Name = "lblStuAddress";
            this.lblStuAddress.Size = new System.Drawing.Size(42, 14);
            this.lblStuAddress.TabIndex = 72;
            this.lblStuAddress.Text = "住 址";
            // 
            // lblStuTel
            // 
            this.lblStuTel.AutoSize = true;
            this.lblStuTel.BackColor = System.Drawing.Color.Transparent;
            this.lblStuTel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuTel.Location = new System.Drawing.Point(40, 139);
            this.lblStuTel.Name = "lblStuTel";
            this.lblStuTel.Size = new System.Drawing.Size(63, 14);
            this.lblStuTel.TabIndex = 71;
            this.lblStuTel.Text = "联系方式";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.BackColor = System.Drawing.Color.Transparent;
            this.lblStuName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuName.Location = new System.Drawing.Point(41, 55);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(49, 14);
            this.lblStuName.TabIndex = 70;
            this.lblStuName.Text = "姓  名";
            // 
            // lblStuNo
            // 
            this.lblStuNo.AutoSize = true;
            this.lblStuNo.BackColor = System.Drawing.Color.Transparent;
            this.lblStuNo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuNo.Location = new System.Drawing.Point(41, 19);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(49, 14);
            this.lblStuNo.TabIndex = 69;
            this.lblStuNo.Text = "编　号";
            // 
            // lblStuSex
            // 
            this.lblStuSex.AutoSize = true;
            this.lblStuSex.BackColor = System.Drawing.Color.Transparent;
            this.lblStuSex.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuSex.Location = new System.Drawing.Point(40, 97);
            this.lblStuSex.Name = "lblStuSex";
            this.lblStuSex.Size = new System.Drawing.Size(49, 14);
            this.lblStuSex.TabIndex = 68;
            this.lblStuSex.Text = "性  别";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthDate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBirthDate.Location = new System.Drawing.Point(275, 97);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(63, 14);
            this.lblBirthDate.TabIndex = 67;
            this.lblBirthDate.Text = "出生日期";
            // 
            // lblEntranceTime
            // 
            this.lblEntranceTime.AutoSize = true;
            this.lblEntranceTime.BackColor = System.Drawing.Color.Transparent;
            this.lblEntranceTime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEntranceTime.Location = new System.Drawing.Point(275, 139);
            this.lblEntranceTime.Name = "lblEntranceTime";
            this.lblEntranceTime.Size = new System.Drawing.Size(63, 14);
            this.lblEntranceTime.TabIndex = 66;
            this.lblEntranceTime.Text = "入学时间";
            // 
            // lblStuId
            // 
            this.lblStuId.AutoSize = true;
            this.lblStuId.BackColor = System.Drawing.Color.Transparent;
            this.lblStuId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuId.Location = new System.Drawing.Point(40, 22);
            this.lblStuId.Name = "lblStuId";
            this.lblStuId.Size = new System.Drawing.Size(0, 14);
            this.lblStuId.TabIndex = 65;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(344, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rabMan
            // 
            this.rabMan.AutoSize = true;
            this.rabMan.BackColor = System.Drawing.Color.Transparent;
            this.rabMan.Checked = true;
            this.rabMan.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabMan.Location = new System.Drawing.Point(114, 97);
            this.rabMan.Name = "rabMan";
            this.rabMan.Size = new System.Drawing.Size(39, 18);
            this.rabMan.TabIndex = 63;
            this.rabMan.TabStop = true;
            this.rabMan.Text = "男";
            this.rabMan.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(92, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "提　交";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ModifyStuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(497, 407);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEntranceTime);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.cmbClassId);
            this.Controls.Add(this.rabWoman);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtStuTel);
            this.Controls.Add(this.txtStuNo);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblStuAddress);
            this.Controls.Add(this.lblStuTel);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.lblStuNo);
            this.Controls.Add(this.lblStuSex);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblEntranceTime);
            this.Controls.Add(this.lblStuId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rabMan);
            this.Controls.Add(this.btnSave);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "ModifyStuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改学生信息";
            this.Load += new System.EventHandler(this.ModifyStuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEntranceTime;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cmbClassId;
        private System.Windows.Forms.RadioButton rabWoman;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtStuTel;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblStuAddress;
        private System.Windows.Forms.Label lblStuTel;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblStuNo;
        private System.Windows.Forms.Label lblStuSex;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblEntranceTime;
        private System.Windows.Forms.Label lblStuId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rabMan;
        private System.Windows.Forms.Button btnSave;
    }
}