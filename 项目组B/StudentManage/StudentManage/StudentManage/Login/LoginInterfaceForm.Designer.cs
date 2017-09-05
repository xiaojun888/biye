namespace StudentManage.Login
{
    partial class LoginInterfaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginInterfaceForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rabAdmin = new System.Windows.Forms.RadioButton();
            this.rabTea = new System.Windows.Forms.RadioButton();
            this.rabStu = new System.Windows.Forms.RadioButton();
            this.skinEngine2 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用学生信息管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(73, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "账　号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(73, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "密　码";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserNo.Location = new System.Drawing.Point(137, 64);
            this.txtUserNo.MaxLength = 20;
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(113, 23);
            this.txtUserNo.TabIndex = 5;
            this.txtUserNo.Text = "system";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassWord.Location = new System.Drawing.Point(137, 110);
            this.txtPassWord.MaxLength = 28;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(113, 23);
            this.txtPassWord.TabIndex = 6;
            this.txtPassWord.Text = "521521";
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(76, 220);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "登　陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(211, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "退　出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rabAdmin
            // 
            this.rabAdmin.AutoSize = true;
            this.rabAdmin.Checked = true;
            this.rabAdmin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabAdmin.Location = new System.Drawing.Point(55, 166);
            this.rabAdmin.Name = "rabAdmin";
            this.rabAdmin.Size = new System.Drawing.Size(67, 18);
            this.rabAdmin.TabIndex = 9;
            this.rabAdmin.TabStop = true;
            this.rabAdmin.Text = "管理员";
            this.rabAdmin.UseVisualStyleBackColor = true;
            // 
            // rabTea
            // 
            this.rabTea.AutoSize = true;
            this.rabTea.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabTea.Location = new System.Drawing.Point(160, 166);
            this.rabTea.Name = "rabTea";
            this.rabTea.Size = new System.Drawing.Size(53, 18);
            this.rabTea.TabIndex = 10;
            this.rabTea.Text = "教师";
            this.rabTea.UseVisualStyleBackColor = true;
            // 
            // rabStu
            // 
            this.rabStu.AutoSize = true;
            this.rabStu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabStu.Location = new System.Drawing.Point(246, 166);
            this.rabStu.Name = "rabStu";
            this.rabStu.Size = new System.Drawing.Size(53, 18);
            this.rabStu.TabIndex = 11;
            this.rabStu.Text = "学生";
            this.rabStu.UseVisualStyleBackColor = true;
            // 
            // skinEngine2
            // 
            this.skinEngine2.SerialNumber = "kUb2DF5pvGF3X9dKPFvIdkXQ0sE8LkAVp9fMme9wCnjZ+ArdRVlxKw==";
            this.skinEngine2.SkinFile = null;
            this.skinEngine2.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine2.SkinStreamMain")));
            // 
            // LoginInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(354, 293);
            this.Controls.Add(this.rabStu);
            this.Controls.Add(this.rabTea);
            this.Controls.Add(this.rabAdmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginInterfaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生管理系统";
            this.Load += new System.EventHandler(this.LoginInterfaceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rabAdmin;
        private System.Windows.Forms.RadioButton rabTea;
        private System.Windows.Forms.RadioButton rabStu;
        public Sunisoft.IrisSkin.SkinEngine skinEngine2;
        //private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}