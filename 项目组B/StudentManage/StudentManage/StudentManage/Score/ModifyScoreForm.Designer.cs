namespace StudentManage.Score
{
    partial class ModifyScoreForm
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
            this.lblStuNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtCourseNo = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStuNo
            // 
            this.lblStuNo.AutoSize = true;
            this.lblStuNo.Location = new System.Drawing.Point(36, 29);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(53, 12);
            this.lblStuNo.TabIndex = 0;
            this.lblStuNo.Text = "学生编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "学生姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "课程编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "课程名称";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(33, 232);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(53, 12);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "成　　绩";
            // 
            // txtStuNo
            // 
            this.txtStuNo.Location = new System.Drawing.Point(104, 24);
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.ReadOnly = true;
            this.txtStuNo.Size = new System.Drawing.Size(89, 21);
            this.txtStuNo.TabIndex = 5;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(104, 72);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.ReadOnly = true;
            this.txtStuName.Size = new System.Drawing.Size(89, 21);
            this.txtStuName.TabIndex = 6;
            // 
            // txtCourseNo
            // 
            this.txtCourseNo.Location = new System.Drawing.Point(103, 121);
            this.txtCourseNo.Name = "txtCourseNo";
            this.txtCourseNo.ReadOnly = true;
            this.txtCourseNo.Size = new System.Drawing.Size(90, 21);
            this.txtCourseNo.TabIndex = 7;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(103, 172);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.ReadOnly = true;
            this.txtCourseName.Size = new System.Drawing.Size(90, 21);
            this.txtCourseName.TabIndex = 8;
            // 
            // nudScore
            // 
            this.nudScore.DecimalPlaces = 1;
            this.nudScore.Location = new System.Drawing.Point(104, 226);
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(67, 21);
            this.nudScore.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保　存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "取　消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ModifyScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 367);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudScore);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseNo);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStuNo);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStuNo);
            this.Name = "ModifyScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改成绩";
            this.Load += new System.EventHandler(this.ModifyScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStuNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtCourseNo;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.NumericUpDown nudScore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
    }
}