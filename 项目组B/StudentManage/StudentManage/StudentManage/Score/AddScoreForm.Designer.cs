namespace StudentManage.Score
{
    partial class AddScoreForm
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
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblStuNo = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.cmbClassName = new System.Windows.Forms.ComboBox();
            this.cmbStuNo = new System.Windows.Forms.ComboBox();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStuName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(32, 24);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(53, 12);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "班级名称";
            // 
            // lblStuNo
            // 
            this.lblStuNo.AutoSize = true;
            this.lblStuNo.Location = new System.Drawing.Point(32, 74);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(53, 12);
            this.lblStuNo.TabIndex = 1;
            this.lblStuNo.Text = "学生编号";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(31, 122);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(53, 12);
            this.lblStuName.TabIndex = 2;
            this.lblStuName.Text = "学生姓名";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(31, 179);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(53, 12);
            this.lblCourseName.TabIndex = 3;
            this.lblCourseName.Text = "课程名称";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(32, 236);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(53, 12);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "成　　绩";
            // 
            // cmbClassName
            // 
            this.cmbClassName.FormattingEnabled = true;
            this.cmbClassName.Location = new System.Drawing.Point(90, 19);
            this.cmbClassName.Name = "cmbClassName";
            this.cmbClassName.Size = new System.Drawing.Size(101, 20);
            this.cmbClassName.TabIndex = 5;
            this.cmbClassName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbStuNo
            // 
            this.cmbStuNo.FormattingEnabled = true;
            this.cmbStuNo.Location = new System.Drawing.Point(91, 71);
            this.cmbStuNo.Name = "cmbStuNo";
            this.cmbStuNo.Size = new System.Drawing.Size(101, 20);
            this.cmbStuNo.TabIndex = 6;
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(91, 175);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(102, 20);
            this.cmbCourseName.TabIndex = 8;
            // 
            // nudScore
            // 
            this.nudScore.DecimalPlaces = 1;
            this.nudScore.Location = new System.Drawing.Point(91, 230);
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(66, 21);
            this.nudScore.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(37, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保　存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(143, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取　消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(91, 119);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.ReadOnly = true;
            this.txtStuName.Size = new System.Drawing.Size(80, 21);
            this.txtStuName.TabIndex = 12;
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 367);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudScore);
            this.Controls.Add(this.cmbCourseName);
            this.Controls.Add(this.cmbStuNo);
            this.Controls.Add(this.cmbClassName);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.lblStuNo);
            this.Controls.Add(this.lblClassName);
            this.Name = "AddScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加成绩";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblStuNo;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ComboBox cmbClassName;
        private System.Windows.Forms.ComboBox cmbStuNo;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.NumericUpDown nudScore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStuName;
    }
}