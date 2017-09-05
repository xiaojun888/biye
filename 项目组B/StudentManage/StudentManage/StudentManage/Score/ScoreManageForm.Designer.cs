namespace StudentManage.Score
{
    partial class ScoreManageForm
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
            this.menuAddScore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModifyScore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchScore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchByTea = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchByStu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchByCla = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchByCou = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dgvScore = new System.Windows.Forms.DataGridView();
            this.lblSearchScore = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtSearchScore = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddScore,
            this.menuModifyScore,
            this.menuSearchScore,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAddScore
            // 
            this.menuAddScore.Name = "menuAddScore";
            this.menuAddScore.Size = new System.Drawing.Size(68, 21);
            this.menuAddScore.Text = "添加成绩";
            this.menuAddScore.Click += new System.EventHandler(this.menuAddScore_Click);
            // 
            // menuModifyScore
            // 
            this.menuModifyScore.Name = "menuModifyScore";
            this.menuModifyScore.Size = new System.Drawing.Size(68, 21);
            this.menuModifyScore.Text = "修改成绩";
            this.menuModifyScore.Click += new System.EventHandler(this.menuModifyScore_Click);
            // 
            // menuSearchScore
            // 
            this.menuSearchScore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSearchByTea,
            this.menuSearchByStu,
            this.menuSearchByCla,
            this.menuSearchByCou,
            this.menuSearchAll});
            this.menuSearchScore.Name = "menuSearchScore";
            this.menuSearchScore.Size = new System.Drawing.Size(68, 21);
            this.menuSearchScore.Text = "查询成绩";
            // 
            // menuSearchByTea
            // 
            this.menuSearchByTea.Name = "menuSearchByTea";
            this.menuSearchByTea.Size = new System.Drawing.Size(148, 22);
            this.menuSearchByTea.Text = "按教师查询";
            this.menuSearchByTea.Click += new System.EventHandler(this.menuSearchByTea_Click);
            // 
            // menuSearchByStu
            // 
            this.menuSearchByStu.Name = "menuSearchByStu";
            this.menuSearchByStu.Size = new System.Drawing.Size(148, 22);
            this.menuSearchByStu.Text = "按学生查询";
            this.menuSearchByStu.Click += new System.EventHandler(this.menuSearchByStu_Click);
            // 
            // menuSearchByCla
            // 
            this.menuSearchByCla.Name = "menuSearchByCla";
            this.menuSearchByCla.Size = new System.Drawing.Size(148, 22);
            this.menuSearchByCla.Text = "按班级查询";
            this.menuSearchByCla.Click += new System.EventHandler(this.menuSearchByCla_Click);
            // 
            // menuSearchByCou
            // 
            this.menuSearchByCou.Name = "menuSearchByCou";
            this.menuSearchByCou.Size = new System.Drawing.Size(148, 22);
            this.menuSearchByCou.Text = "按课程查询";
            this.menuSearchByCou.Click += new System.EventHandler(this.menuSearchByCou_Click);
            // 
            // menuSearchAll
            // 
            this.menuSearchAll.Name = "menuSearchAll";
            this.menuSearchAll.Size = new System.Drawing.Size(148, 22);
            this.menuSearchAll.Text = "查询所有成绩";
            this.menuSearchAll.Click += new System.EventHandler(this.menuSearchAll_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(44, 21);
            this.menuExit.Text = "退出";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 117);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(500, 249);
            this.dataGridView.TabIndex = 1;
            // 
            // dgvScore
            // 
            this.dgvScore.Location = new System.Drawing.Point(0, 0);
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.Size = new System.Drawing.Size(240, 150);
            this.dgvScore.TabIndex = 0;
            // 
            // lblSearchScore
            // 
            this.lblSearchScore.AutoSize = true;
            this.lblSearchScore.Location = new System.Drawing.Point(17, 24);
            this.lblSearchScore.Name = "lblSearchScore";
            this.lblSearchScore.Size = new System.Drawing.Size(89, 12);
            this.lblSearchScore.TabIndex = 2;
            this.lblSearchScore.Text = "请输入教师编号";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(49, 55);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(53, 12);
            this.lblStuName.TabIndex = 3;
            this.lblStuName.Text = "学生名称";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.txtStuName);
            this.gpbSearch.Controls.Add(this.txtSearchScore);
            this.gpbSearch.Controls.Add(this.lblSearchScore);
            this.gpbSearch.Controls.Add(this.lblStuName);
            this.gpbSearch.Location = new System.Drawing.Point(27, 27);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(254, 84);
            this.gpbSearch.TabIndex = 4;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "查询条件";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(112, 51);
            this.txtStuName.MaxLength = 12;
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 21);
            this.txtStuName.TabIndex = 5;
            // 
            // txtSearchScore
            // 
            this.txtSearchScore.Location = new System.Drawing.Point(112, 16);
            this.txtSearchScore.MaxLength = 12;
            this.txtSearchScore.Name = "txtSearchScore";
            this.txtSearchScore.Size = new System.Drawing.Size(100, 21);
            this.txtSearchScore.TabIndex = 4;
            this.txtSearchScore.Text = "321";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(309, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查　找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(309, 77);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "删  除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(401, 34);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "重　置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(400, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取　消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ScoreManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 365);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gpbSearch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScoreManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩管理";
            this.Load += new System.EventHandler(this.ScoreManageForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAddScore;
        private System.Windows.Forms.ToolStripMenuItem menuModifyScore;
        private System.Windows.Forms.ToolStripMenuItem menuSearchScore;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblSearchScore;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.DataGridView dgvScore;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtSearchScore;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem menuSearchByTea;
        private System.Windows.Forms.ToolStripMenuItem menuSearchByStu;
        private System.Windows.Forms.ToolStripMenuItem menuSearchByCla;
        private System.Windows.Forms.ToolStripMenuItem menuSearchByCou;
        private System.Windows.Forms.ToolStripMenuItem menuSearchAll;
    }
}