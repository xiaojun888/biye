using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManage.Login
{
    public partial class ModifyPWDForm : Form
    {
        public int iRight;
        public string struserno;
        
        public ModifyPWDForm(int iRights,string UserNo)      
        {
            InitializeComponent();
            iRight = iRights;
            struserno = UserNo;
          //获取当前用户账号
            lblUserNo.Text = struserno;
           
        }
        
        //修改用户密码
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Login.Login objLogin = new Manage.Login.Login(strConnection);
            string strErr = "";
            Model.Users.Users objUsers = new Model.Users.Users();

            string struserno = this.lblUserNo.Text;
           
            if (this.txtNewPWD.Text == "" || this.txtConfirmPWD.Text == "")
            {
                MessageBox.Show("请确认信息是否填写完整！");
            }
            else
            {
                if (this.txtNewPWD.Text != this.txtConfirmPWD.Text)
                {
                    MessageBox.Show("两次输入的密码不一致,请重新输入！");
                    this.txtNewPWD.Clear();
                    this.txtConfirmPWD.Clear();
                }
                else
                {
                  
                    if (this.txtNewPWD.Text == this.txtConfirmPWD.Text && this.txtNewPWD.Text.Length > 14)
                    {
                        MessageBox.Show("密码长度限制在14位之内！");
                        this.txtNewPWD.Clear();
                        this.txtConfirmPWD.Clear();
                    }
                    else 
                    {
                        objUsers.PassWord = txtNewPWD.Text;
                    }

                    int iRent = objLogin.ChangePWD(iRight, struserno,objUsers, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("修改密码成功");
                        this.Close();
                    }
                }

            }

        }

        //重置
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtNewPWD.Clear();
            this.txtConfirmPWD.Clear();
        }

        //退出
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}