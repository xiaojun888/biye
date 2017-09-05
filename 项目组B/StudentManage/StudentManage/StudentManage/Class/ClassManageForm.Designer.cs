namespace StudentManage.Class
{
    partial class ClassManageForm
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
            this.menuAddClass = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModifyClass = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchClass = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelClass = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassNo = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblClassNo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddClass,
            this.menuModifyClass,
            this.menuSearchClass,
            this.menuDelClass,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAddClass
            // 
            this.menuAddClass.Name = "menuAddClass";
            this.menuAddClass.Size = new System.Drawing.Size(68, 21);
            this.menuAddClass.Text = "添加班级";
            this.menuAddClass.Click += new System.EventHandler(this.menuAddClass_Click);
            // 
            // menuModifyClass
            // 
            this.menuModifyClass.Name = "menuModifyClass";
            this.menuModifyClass.Size = new System.Drawing.Size(68, 21);
            this.menuModifyClass.Text = "修改班级";
            this.menuModifyClass.Click += new System.EventHandler(this.menuModifyClass_Click);
            // 
            // menuSearchClass
            // 
            this.menuSearchClass.Name = "menuSearchClass";
            this.menuSearchClass.Size = new System.Drawing.Size(68, 21);
            this.menuSearchClass.Text = "查询班级";
            this.menuSearchClass.Click += new System.EventHandler(this.menuSearchClass_Click);
            // 
            // menuDelClass
            // 
            this.menuDelClass.Name = "menuDelClass";
            this.menuDelClass.Size = new System.Drawing.Size(68, 21);
            this.menuDelClass.Text = "删除班级";
            this.menuDelClass.Click += new System.EventHandler(this.menuDelClass_Click);
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
            this.dataGridView.Location = new System.Drawing.Point(0, 113);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(478, 264);
            this.dataGridView.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtClassName);
            this.groupBox.Controls.Add(this.txtClassNo);
            this.groupBox.Controls.Add(this.lblClassName);
            this.groupBox.Controls.Add(this.lblClassNo);
            this.groupBox.Location = new System.Drawing.Point(12, 30);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(347, 64);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "查询条件";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(239, 22);
            this.txtClassName.MaxLength = 12;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(85, 21);
            this.txtClassName.TabIndex = 3;
            this.txtClassName.Text = "软件1402";
            // 
            // txtClassNo
            // 
            this.txtClassNo.Location = new System.Drawing.Point(70, 22);
            this.txtClassNo.MaxLength = 12;
            this.txtClassNo.Name = "txtClassNo";
            this.txtClassNo.Size = new System.Drawing.Size(84, 21);
            this.txtClassNo.TabIndex = 2;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(173, 27);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(53, 12);
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Text = "班级名称";
            // 
            // lblClassNo
            // 
            this.lblClassNo.AutoSize = true;
            this.lblClassNo.Location = new System.Drawing.Point(9, 26);
            this.lblClassNo.Name = "lblClassNo";
            this.lblClassNo.Size = new System.Drawing.Size(53, 12);
            this.lblClassNo.TabIndex = 0;
            this.lblClassNo.Text = "班级编号";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(380, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查　询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(380, 22);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "修　改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(380, 86);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删　除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // ClassManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 377);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClassManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班级信息管理";
            this.Load += new System.EventHandler(this.ClassManageForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAddClass;
        private System.Windows.Forms.ToolStripMenuItem menuModifyClass;
        private System.Windows.Forms.ToolStripMenuItem menuSearchClass;
        private System.Windows.Forms.ToolStripMenuItem menuDelClass;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassNo;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblClassNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDel;
    }
}