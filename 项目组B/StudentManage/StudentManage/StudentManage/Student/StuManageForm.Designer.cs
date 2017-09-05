namespace StudentManage.Student
{
    partial class StuManageForm
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
            this.menuAddStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModifyStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.lblStuNo = new System.Windows.Forms.Label();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddStu,
            this.menuModifyStu,
            this.menuSearchStu,
            this.menuDelStu,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAddStu
            // 
            this.menuAddStu.Name = "menuAddStu";
            this.menuAddStu.Size = new System.Drawing.Size(92, 21);
            this.menuAddStu.Text = "增加学生信息";
            this.menuAddStu.Click += new System.EventHandler(this.menuAddStu_Click);
            // 
            // menuModifyStu
            // 
            this.menuModifyStu.Name = "menuModifyStu";
            this.menuModifyStu.Size = new System.Drawing.Size(92, 21);
            this.menuModifyStu.Text = "修改学生信息";
            this.menuModifyStu.Click += new System.EventHandler(this.menuModifyStu_Click);
            // 
            // menuSearchStu
            // 
            this.menuSearchStu.Name = "menuSearchStu";
            this.menuSearchStu.Size = new System.Drawing.Size(92, 21);
            this.menuSearchStu.Text = "查询学生信息";
            this.menuSearchStu.Click += new System.EventHandler(this.menuSearchStu_Click);
            // 
            // menuDelStu
            // 
            this.menuDelStu.Name = "menuDelStu";
            this.menuDelStu.Size = new System.Drawing.Size(92, 21);
            this.menuDelStu.Text = "删除学生信息";
            this.menuDelStu.Click += new System.EventHandler(this.menuDelStu_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(44, 21);
            this.menuExit.Text = "返回";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblClassName);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.lblStuName);
            this.groupBox1.Controls.Add(this.txtStuName);
            this.groupBox1.Controls.Add(this.lblStuNo);
            this.groupBox1.Controls.Add(this.txtStuNo);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 57);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(363, 24);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(53, 12);
            this.lblClassName.TabIndex = 14;
            this.lblClassName.Text = "班级名称";
            // 
            // txtClassName
            // 
            this.txtClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassName.Location = new System.Drawing.Point(435, 21);
            this.txtClassName.MaxLength = 10;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(98, 21);
            this.txtClassName.TabIndex = 14;
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(180, 21);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(53, 12);
            this.lblStuName.TabIndex = 13;
            this.lblStuName.Text = "学生姓名";
            // 
            // txtStuName
            // 
            this.txtStuName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStuName.Location = new System.Drawing.Point(248, 21);
            this.txtStuName.MaxLength = 4;
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(98, 21);
            this.txtStuName.TabIndex = 13;
            this.txtStuName.Text = "李星辰";
            // 
            // lblStuNo
            // 
            this.lblStuNo.AutoSize = true;
            this.lblStuNo.Location = new System.Drawing.Point(6, 21);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(53, 12);
            this.lblStuNo.TabIndex = 12;
            this.lblStuNo.Text = "学生编号";
            // 
            // txtStuNo
            // 
            this.txtStuNo.Location = new System.Drawing.Point(65, 18);
            this.txtStuNo.MaxLength = 10;
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.Size = new System.Drawing.Size(98, 21);
            this.txtStuNo.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 134);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(568, 317);
            this.dataGridView.TabIndex = 13;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(259, 90);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 25;
            this.btnModify.Text = "修　改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(458, 90);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 24;
            this.btnDel.Text = "删　除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(88, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "查　询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // StuManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 451);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StuManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生管理";
            this.Load += new System.EventHandler(this.StuManageForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAddStu;
        private System.Windows.Forms.ToolStripMenuItem menuModifyStu;
        private System.Windows.Forms.ToolStripMenuItem menuSearchStu;
        private System.Windows.Forms.ToolStripMenuItem menuDelStu;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Label lblStuNo;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearch;
    }
}