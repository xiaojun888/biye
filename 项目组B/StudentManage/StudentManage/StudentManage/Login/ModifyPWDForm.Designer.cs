namespace StudentManage.Login
{
    partial class ModifyPWDForm
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
            this.lblUserNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.grpChangePwd = new System.Windows.Forms.GroupBox();
            this.txtConfirmPWD = new System.Windows.Forms.TextBox();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.txtNewPWD = new System.Windows.Forms.TextBox();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpChangePwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserNo
            // 
            this.lblUserNo.AutoSize = true;
            this.lblUserNo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserNo.Location = new System.Drawing.Point(130, 34);
            this.lblUserNo.Name = "lblUserNo";
            this.lblUserNo.Size = new System.Drawing.Size(49, 14);
            this.lblUserNo.TabIndex = 17;
            this.lblUserNo.Text = "Label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = " 帐 号:";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(273, 29);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 15;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // grpChangePwd
            // 
            this.grpChangePwd.Controls.Add(this.txtConfirmPWD);
            this.grpChangePwd.Controls.Add(this.lblConfirmPwd);
            this.grpChangePwd.Controls.Add(this.txtNewPWD);
            this.grpChangePwd.Controls.Add(this.lblNewPwd);
            this.grpChangePwd.Location = new System.Drawing.Point(12, 77);
            this.grpChangePwd.Name = "grpChangePwd";
            this.grpChangePwd.Size = new System.Drawing.Size(291, 110);
            this.grpChangePwd.TabIndex = 14;
            this.grpChangePwd.TabStop = false;
            this.grpChangePwd.Text = "编辑";
            // 
            // txtConfirmPWD
            // 
            this.txtConfirmPWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPWD.Location = new System.Drawing.Point(94, 61);
            this.txtConfirmPWD.MaxLength = 50;
            this.txtConfirmPWD.Name = "txtConfirmPWD";
            this.txtConfirmPWD.PasswordChar = '*';
            this.txtConfirmPWD.Size = new System.Drawing.Size(179, 21);
            this.txtConfirmPWD.TabIndex = 1;
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.AutoSize = true;
            this.lblConfirmPwd.Location = new System.Drawing.Point(15, 66);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(77, 12);
            this.lblConfirmPwd.TabIndex = 4;
            this.lblConfirmPwd.Text = "确认新密码：";
            // 
            // txtNewPWD
            // 
            this.txtNewPWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPWD.Location = new System.Drawing.Point(94, 25);
            this.txtNewPWD.MaxLength = 50;
            this.txtNewPWD.Name = "txtNewPWD";
            this.txtNewPWD.PasswordChar = '*';
            this.txtNewPWD.Size = new System.Drawing.Size(179, 21);
            this.txtNewPWD.TabIndex = 0;
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Location = new System.Drawing.Point(15, 30);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(59, 12);
            this.lblNewPwd.TabIndex = 2;
            this.lblNewPwd.Text = " 新密码：";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(228, 221);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(53, 221);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ModifyPWDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(360, 273);
            this.Controls.Add(this.lblUserNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.grpChangePwd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "ModifyPWDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.grpChangePwd.ResumeLayout(false);
            this.grpChangePwd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox grpChangePwd;
        private System.Windows.Forms.TextBox txtConfirmPWD;
        private System.Windows.Forms.Label lblConfirmPwd;
        private System.Windows.Forms.TextBox txtNewPWD;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
    }
}