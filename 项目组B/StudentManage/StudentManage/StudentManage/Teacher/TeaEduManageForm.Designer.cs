namespace StudentManage.Teacher
{
    partial class TeaEduManageForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClassSearchName = new System.Windows.Forms.TextBox();
            this.txtTeaSearchName = new System.Windows.Forms.TextBox();
            this.txtCourseSearchName = new System.Windows.Forms.TextBox();
            this.txtTeaSearchNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.cmbClassName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAddTeaEdu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMotifyTeaEdu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchTeaEdu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelTeaEdu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtTeaNo = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAddTeaEdu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClassSearchName);
            this.groupBox1.Controls.Add(this.txtTeaSearchName);
            this.groupBox1.Controls.Add(this.txtCourseSearchName);
            this.groupBox1.Controls.Add(this.txtTeaSearchNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(196, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // txtClassSearchName
            // 
            this.txtClassSearchName.Location = new System.Drawing.Point(192, 69);
            this.txtClassSearchName.MaxLength = 12;
            this.txtClassSearchName.Name = "txtClassSearchName";
            this.txtClassSearchName.Size = new System.Drawing.Size(73, 21);
            this.txtClassSearchName.TabIndex = 18;
            // 
            // txtTeaSearchName
            // 
            this.txtTeaSearchName.Location = new System.Drawing.Point(68, 70);
            this.txtTeaSearchName.MaxLength = 5;
            this.txtTeaSearchName.Name = "txtTeaSearchName";
            this.txtTeaSearchName.Size = new System.Drawing.Size(61, 21);
            this.txtTeaSearchName.TabIndex = 17;
            // 
            // txtCourseSearchName
            // 
            this.txtCourseSearchName.Location = new System.Drawing.Point(193, 26);
            this.txtCourseSearchName.MaxLength = 12;
            this.txtCourseSearchName.Name = "txtCourseSearchName";
            this.txtCourseSearchName.Size = new System.Drawing.Size(72, 21);
            this.txtCourseSearchName.TabIndex = 16;
            this.txtCourseSearchName.Text = "积极心理学";
            // 
            // txtTeaSearchNo
            // 
            this.txtTeaSearchNo.Location = new System.Drawing.Point(68, 25);
            this.txtTeaSearchNo.MaxLength = 12;
            this.txtTeaSearchNo.Name = "txtTeaSearchNo";
            this.txtTeaSearchNo.Size = new System.Drawing.Size(61, 21);
            this.txtTeaSearchNo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "教师名称";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "班级名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "课程名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "教师编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "教师编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "课程名称";
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(72, 78);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(102, 20);
            this.cmbCourseName.TabIndex = 3;
            // 
            // cmbClassName
            // 
            this.cmbClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassName.FormattingEnabled = true;
            this.cmbClassName.Location = new System.Drawing.Point(72, 116);
            this.cmbClassName.Name = "cmbClassName";
            this.cmbClassName.Size = new System.Drawing.Size(102, 20);
            this.cmbClassName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "班级名称";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddTeaEdu,
            this.menuMotifyTeaEdu,
            this.menuSearchTeaEdu,
            this.menuDelTeaEdu,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAddTeaEdu
            // 
            this.menuAddTeaEdu.Name = "menuAddTeaEdu";
            this.menuAddTeaEdu.Size = new System.Drawing.Size(92, 21);
            this.menuAddTeaEdu.Text = "添加教师职务";
            this.menuAddTeaEdu.Click += new System.EventHandler(this.btnAddTeaEdu_Click);
            // 
            // menuMotifyTeaEdu
            // 
            this.menuMotifyTeaEdu.Name = "menuMotifyTeaEdu";
            this.menuMotifyTeaEdu.Size = new System.Drawing.Size(92, 21);
            this.menuMotifyTeaEdu.Text = "修改教师职务";
            this.menuMotifyTeaEdu.Click += new System.EventHandler(this.menuMotifyTeaEdu_Click);
            // 
            // menuSearchTeaEdu
            // 
            this.menuSearchTeaEdu.Name = "menuSearchTeaEdu";
            this.menuSearchTeaEdu.Size = new System.Drawing.Size(92, 21);
            this.menuSearchTeaEdu.Text = "查询教师职务";
            this.menuSearchTeaEdu.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // menuDelTeaEdu
            // 
            this.menuDelTeaEdu.Name = "menuDelTeaEdu";
            this.menuDelTeaEdu.Size = new System.Drawing.Size(92, 21);
            this.menuDelTeaEdu.Text = "删除教师职务";
            this.menuDelTeaEdu.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(44, 21);
            this.menuExit.Text = "返回";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 143);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(542, 264);
            this.dataGridView.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(479, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "查　询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(479, 113);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(61, 23);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "删　除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtTeaNo
            // 
            this.txtTeaNo.Location = new System.Drawing.Point(72, 40);
            this.txtTeaNo.MaxLength = 12;
            this.txtTeaNo.Name = "txtTeaNo";
            this.txtTeaNo.ReadOnly = true;
            this.txtTeaNo.Size = new System.Drawing.Size(61, 21);
            this.txtTeaNo.TabIndex = 19;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(139, 37);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(35, 23);
            this.btnSelect.TabIndex = 20;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAddTeaEdu
            // 
            this.btnAddTeaEdu.Location = new System.Drawing.Point(479, 37);
            this.btnAddTeaEdu.Name = "btnAddTeaEdu";
            this.btnAddTeaEdu.Size = new System.Drawing.Size(61, 23);
            this.btnAddTeaEdu.TabIndex = 21;
            this.btnAddTeaEdu.Text = "添　加";
            this.btnAddTeaEdu.UseVisualStyleBackColor = true;
            this.btnAddTeaEdu.Click += new System.EventHandler(this.btnAddTeaEdu_Click);
            // 
            // TeaEduManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 415);
            this.Controls.Add(this.btnAddTeaEdu);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtTeaNo);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbClassName);
            this.Controls.Add(this.cmbCourseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeaEduManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师职务管理";
            this.Load += new System.EventHandler(this.TeaEduManageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.ComboBox cmbClassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAddTeaEdu;
        private System.Windows.Forms.ToolStripMenuItem menuDelTeaEdu;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtClassSearchName;
        private System.Windows.Forms.TextBox txtTeaSearchName;
        private System.Windows.Forms.TextBox txtCourseSearchName;
        private System.Windows.Forms.TextBox txtTeaSearchNo;
        public System.Windows.Forms.TextBox txtTeaNo;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ToolStripMenuItem menuSearchTeaEdu;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuMotifyTeaEdu;
        private System.Windows.Forms.Button btnAddTeaEdu;
    }
}