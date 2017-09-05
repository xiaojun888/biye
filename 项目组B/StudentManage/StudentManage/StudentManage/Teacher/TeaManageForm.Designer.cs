namespace StudentManage.Teacher
{
    partial class TeaManageForm
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
            this.menuAddTea = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModifyTea = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchTea = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelTea = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTeaEdu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtTeaName = new System.Windows.Forms.TextBox();
            this.lblTeaName = new System.Windows.Forms.Label();
            this.txtTeaNo = new System.Windows.Forms.TextBox();
            this.lblTeaNo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddTea,
            this.menuModifyTea,
            this.menuSearchTea,
            this.menuDelTea,
            this.menuTeaEdu,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAddTea
            // 
            this.menuAddTea.Name = "menuAddTea";
            this.menuAddTea.Size = new System.Drawing.Size(92, 21);
            this.menuAddTea.Text = "增加教师信息";
            this.menuAddTea.Click += new System.EventHandler(this.menuAddTea_Click);
            // 
            // menuModifyTea
            // 
            this.menuModifyTea.Name = "menuModifyTea";
            this.menuModifyTea.Size = new System.Drawing.Size(92, 21);
            this.menuModifyTea.Text = "修改教师信息";
            this.menuModifyTea.Click += new System.EventHandler(this.menuModifyTea_Click);
            // 
            // menuSearchTea
            // 
            this.menuSearchTea.Name = "menuSearchTea";
            this.menuSearchTea.Size = new System.Drawing.Size(92, 21);
            this.menuSearchTea.Text = "查询教师信息";
            this.menuSearchTea.Click += new System.EventHandler(this.menuSearchTea_Click);
            // 
            // menuDelTea
            // 
            this.menuDelTea.Name = "menuDelTea";
            this.menuDelTea.Size = new System.Drawing.Size(92, 21);
            this.menuDelTea.Text = "删除教师信息";
            this.menuDelTea.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // menuTeaEdu
            // 
            this.menuTeaEdu.Name = "menuTeaEdu";
            this.menuTeaEdu.Size = new System.Drawing.Size(92, 21);
            this.menuTeaEdu.Text = "教师职务管理";
            this.menuTeaEdu.Click += new System.EventHandler(this.menuTeaEdu_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(44, 21);
            this.menuExit.Text = "返回";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtTeaName);
            this.groupBox.Controls.Add(this.lblTeaName);
            this.groupBox.Controls.Add(this.txtTeaNo);
            this.groupBox.Controls.Add(this.lblTeaNo);
            this.groupBox.Location = new System.Drawing.Point(24, 42);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(369, 61);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "查询条件";
            // 
            // txtTeaName
            // 
            this.txtTeaName.Location = new System.Drawing.Point(256, 20);
            this.txtTeaName.MaxLength = 12;
            this.txtTeaName.Name = "txtTeaName";
            this.txtTeaName.Size = new System.Drawing.Size(90, 21);
            this.txtTeaName.TabIndex = 3;
            // 
            // lblTeaName
            // 
            this.lblTeaName.AutoSize = true;
            this.lblTeaName.Location = new System.Drawing.Point(189, 26);
            this.lblTeaName.Name = "lblTeaName";
            this.lblTeaName.Size = new System.Drawing.Size(53, 12);
            this.lblTeaName.TabIndex = 2;
            this.lblTeaName.Text = "教师名称";
            // 
            // txtTeaNo
            // 
            this.txtTeaNo.Location = new System.Drawing.Point(78, 21);
            this.txtTeaNo.MaxLength = 12;
            this.txtTeaNo.Name = "txtTeaNo";
            this.txtTeaNo.Size = new System.Drawing.Size(89, 21);
            this.txtTeaNo.TabIndex = 1;
            this.txtTeaNo.Text = "321";
            // 
            // lblTeaNo
            // 
            this.lblTeaNo.AutoSize = true;
            this.lblTeaNo.Location = new System.Drawing.Point(16, 26);
            this.lblTeaNo.Name = "lblTeaNo";
            this.lblTeaNo.Size = new System.Drawing.Size(53, 12);
            this.lblTeaNo.TabIndex = 0;
            this.lblTeaNo.Text = "教师编号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(560, 283);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(448, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查　询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.menuSearchTea_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(448, 66);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "修　改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.menuModifyTea_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(448, 99);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删　除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // TeaManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 423);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeaManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师信息管理";
            this.Load += new System.EventHandler(this.TeaManageForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem menuAddTea;
        public System.Windows.Forms.ToolStripMenuItem menuModifyTea;
        public System.Windows.Forms.ToolStripMenuItem menuSearchTea;
        public System.Windows.Forms.ToolStripMenuItem menuDelTea;
        public System.Windows.Forms.ToolStripMenuItem menuTeaEdu;
        public System.Windows.Forms.ToolStripMenuItem menuExit;
        public System.Windows.Forms.GroupBox groupBox;
        public System.Windows.Forms.TextBox txtTeaName;
        public System.Windows.Forms.Label lblTeaName;
        public System.Windows.Forms.TextBox txtTeaNo;
        public System.Windows.Forms.Label lblTeaNo;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Button btnModify;
        public System.Windows.Forms.Button btnDel;
    }
}