namespace StudentManage.Course
{
    partial class CourseManageForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAddCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModifyCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnModify = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseNo = new System.Windows.Forms.Label();
            this.txtCourseNo = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddCourse,
            this.menuModifyCourse,
            this.menuSearchCourse,
            this.menuDelCourse,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAddCourse
            // 
            this.menuAddCourse.Name = "menuAddCourse";
            this.menuAddCourse.Size = new System.Drawing.Size(68, 21);
            this.menuAddCourse.Text = "添加课程";
            this.menuAddCourse.Click += new System.EventHandler(this.menuAddCourse_Click);
            // 
            // menuModifyCourse
            // 
            this.menuModifyCourse.Name = "menuModifyCourse";
            this.menuModifyCourse.Size = new System.Drawing.Size(68, 21);
            this.menuModifyCourse.Text = "修改课程";
            this.menuModifyCourse.Click += new System.EventHandler(this.menuModifyCourse_Click);
            // 
            // menuSearchCourse
            // 
            this.menuSearchCourse.Name = "menuSearchCourse";
            this.menuSearchCourse.Size = new System.Drawing.Size(68, 21);
            this.menuSearchCourse.Text = "查询课程";
            this.menuSearchCourse.Click += new System.EventHandler(this.menuSearchCourse_Click);
            // 
            // menuDelCourse
            // 
            this.menuDelCourse.Name = "menuDelCourse";
            this.menuDelCourse.Size = new System.Drawing.Size(68, 21);
            this.menuDelCourse.Text = "删除课程";
            this.menuDelCourse.Click += new System.EventHandler(this.menuDelCourse_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(44, 21);
            this.menuExit.Text = "返回";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(77, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查　询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(418, 107);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删　除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 148);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(524, 258);
            this.dataGridView.TabIndex = 21;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(246, 107);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 22;
            this.btnModify.Text = "修　改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblClassName);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.lblCourseName);
            this.groupBox1.Controls.Add(this.txtCourseName);
            this.groupBox1.Controls.Add(this.lblCourseNo);
            this.groupBox1.Controls.Add(this.txtCourseNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 57);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(347, 22);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(53, 12);
            this.lblClassName.TabIndex = 14;
            this.lblClassName.Text = "班级名称";
            // 
            // txtClassName
            // 
            this.txtClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassName.Location = new System.Drawing.Point(406, 18);
            this.txtClassName.MaxLength = 10;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(94, 21);
            this.txtClassName.TabIndex = 14;
            this.txtClassName.Text = "软件1402";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(175, 22);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(53, 12);
            this.lblCourseName.TabIndex = 13;
            this.lblCourseName.Text = "课程名称";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCourseName.Location = new System.Drawing.Point(234, 18);
            this.txtCourseName.MaxLength = 10;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(94, 21);
            this.txtCourseName.TabIndex = 13;
            // 
            // lblCourseNo
            // 
            this.lblCourseNo.AutoSize = true;
            this.lblCourseNo.Location = new System.Drawing.Point(6, 22);
            this.lblCourseNo.Name = "lblCourseNo";
            this.lblCourseNo.Size = new System.Drawing.Size(53, 12);
            this.lblCourseNo.TabIndex = 12;
            this.lblCourseNo.Text = "课程编号";
            // 
            // txtCourseNo
            // 
            this.txtCourseNo.Location = new System.Drawing.Point(65, 18);
            this.txtCourseNo.MaxLength = 20;
            this.txtCourseNo.Name = "txtCourseNo";
            this.txtCourseNo.Size = new System.Drawing.Size(94, 21);
            this.txtCourseNo.TabIndex = 3;
            // 
            // CourseManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CourseManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程管理";
            this.Load += new System.EventHandler(this.CourseManageForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAddCourse;
        private System.Windows.Forms.ToolStripMenuItem menuModifyCourse;
        private System.Windows.Forms.ToolStripMenuItem menuSearchCourse;
        private System.Windows.Forms.ToolStripMenuItem menuDelCourse;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCourseNo;
        private System.Windows.Forms.TextBox txtCourseNo;
    }
}