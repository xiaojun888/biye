namespace StudentManage.Login
{
    partial class AccountForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuModifyPWD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchTeaAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchStuAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModify = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserNo = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(419, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(4, 94);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(524, 310);
            this.dataGridView.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuModifyPWD,
            this.menuSearchUser,
            this.menuModify,
            this.menuSearchPersonal,
            this.menuDelUser,
            this.btnExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuModifyPWD
            // 
            this.menuModifyPWD.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuModifyPWD.Name = "menuModifyPWD";
            this.menuModifyPWD.Size = new System.Drawing.Size(75, 20);
            this.menuModifyPWD.Text = "密码修改";
            this.menuModifyPWD.Click += new System.EventHandler(this.menuModifyPWD_Click);
            // 
            // menuSearchUser
            // 
            this.menuSearchUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSearchTeaAll,
            this.menuSearchStuAll});
            this.menuSearchUser.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuSearchUser.Name = "menuSearchUser";
            this.menuSearchUser.Size = new System.Drawing.Size(75, 20);
            this.menuSearchUser.Text = "查询用户";
            this.menuSearchUser.Click += new System.EventHandler(this.menuSearchUser_Click);
            // 
            // menuSearchTeaAll
            // 
            this.menuSearchTeaAll.Name = "menuSearchTeaAll";
            this.menuSearchTeaAll.Size = new System.Drawing.Size(186, 22);
            this.menuSearchTeaAll.Text = "查询所有教师用户";
            this.menuSearchTeaAll.Click += new System.EventHandler(this.menuSearchTeaAll_Click);
            // 
            // menuSearchStuAll
            // 
            this.menuSearchStuAll.Name = "menuSearchStuAll";
            this.menuSearchStuAll.Size = new System.Drawing.Size(186, 22);
            this.menuSearchStuAll.Text = "查询所有学生用户";
            this.menuSearchStuAll.Click += new System.EventHandler(this.menuSearchStuAll_Click);
            // 
            // menuModify
            // 
            this.menuModify.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuModify.Name = "menuModify";
            this.menuModify.Size = new System.Drawing.Size(75, 20);
            this.menuModify.Text = "信息修改";
            this.menuModify.Click += new System.EventHandler(this.menuModify_Click);
            // 
            // menuSearchPersonal
            // 
            this.menuSearchPersonal.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuSearchPersonal.Name = "menuSearchPersonal";
            this.menuSearchPersonal.Size = new System.Drawing.Size(103, 20);
            this.menuSearchPersonal.Text = "个人信息查询";
            this.menuSearchPersonal.Click += new System.EventHandler(this.menuSearchPersonal_Click);
            // 
            // menuDelUser
            // 
            this.menuDelUser.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuDelUser.Name = "menuDelUser";
            this.menuDelUser.Size = new System.Drawing.Size(75, 20);
            this.menuDelUser.Text = "删除用户";
            this.menuDelUser.Click += new System.EventHandler(this.menuDelUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 20);
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.lblUserNo);
            this.groupBox1.Controls.Add(this.txtUserNo);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 53);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.Location = new System.Drawing.Point(208, 22);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 14);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "用户名称";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserName.Location = new System.Drawing.Point(289, 18);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(94, 23);
            this.txtUserName.TabIndex = 13;
            this.txtUserName.Text = "李星辰";
            // 
            // lblUserNo
            // 
            this.lblUserNo.AutoSize = true;
            this.lblUserNo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserNo.Location = new System.Drawing.Point(6, 22);
            this.lblUserNo.Name = "lblUserNo";
            this.lblUserNo.Size = new System.Drawing.Size(63, 14);
            this.lblUserNo.TabIndex = 12;
            this.lblUserNo.Text = "用户帐号";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserNo.Location = new System.Drawing.Point(81, 18);
            this.txtUserNo.MaxLength = 20;
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(94, 23);
            this.txtUserNo.TabIndex = 3;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(528, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账户管理";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuModifyPWD;
        private System.Windows.Forms.ToolStripMenuItem menuSearchUser;
        private System.Windows.Forms.ToolStripMenuItem menuSearchTeaAll;
        private System.Windows.Forms.ToolStripMenuItem menuSearchStuAll;
        private System.Windows.Forms.ToolStripMenuItem menuModify;
        private System.Windows.Forms.ToolStripMenuItem menuSearchPersonal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserNo;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.ToolStripMenuItem menuDelUser;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
    }
}