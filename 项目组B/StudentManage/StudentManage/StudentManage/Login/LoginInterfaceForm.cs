using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManage.Login
{
    public partial class LoginInterfaceForm : Form
    {   
        //定义新皮肤
        
        Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();
        public LoginInterfaceForm()
        {
            InitializeComponent();
            //选择皮肤文件
            skin.SkinFile = System.Environment.CurrentDirectory + "\\skin\\" + "Wave.ssk";
            //激活当前皮肤
            skin.Active = true;
        }



       private void LoginInterfaceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strErr = "";
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Login.Login objLogin = new Manage.Login.Login(strConnection);

            if (rabAdmin.Checked == true)
            {
                Model.Users.Users objUsers = new Model.Users.Users();
                objUsers.UserNo= txtUserNo.Text.Replace("'", "''");
                objUsers.UserNo = objUsers.UserNo.Trim();
               
                objUsers.PassWord = txtPassWord.Text.Replace("'", "''");
                objUsers.PassWord = objUsers.PassWord.Trim();
                //以管理员身份登录
                //判断输入的用户名和密码是否正确,正确进入 MainForm界面,否则提示您输入的账号或密码错误，请重新输入
                if (txtUserNo.Text == "system" && txtPassWord.Text == "521521")
                {
                    objUsers.Rights = 1;
                    MainForm objEnter = new MainForm(objUsers.UserNo, objUsers.PassWord, objUsers.Rights);
                    this.Visible = false;
                    objEnter.Show();
                }
                else
                {
                    
                    MessageBox.Show("您输入的账号或密码错误，请重新输入！");
                    txtUserNo.Text = "";
                    txtPassWord.Text = "";
                    return;
                }
            }
            ////以教师身份登录
            else if (rabTea.Checked == true)
            {
                Model.Users.Users objUsers = new Model.Users.Users();
                objUsers.UserNo = txtUserNo.Text.Replace("'", "''");
                objUsers.UserNo = objUsers.UserNo.Trim();
                objUsers.UserNo = objUsers.UserNo.Replace("%", @"\%");
               
                objUsers.PassWord = txtPassWord.Text.Replace("'", "''");
                objUsers.PassWord = objUsers.PassWord.Trim();
                objUsers.PassWord = objUsers.PassWord.Replace("%", @"\%");
               
                objUsers.Rights = 2;
                int iRent = objLogin.JudgeExist(objUsers.UserNo, objUsers.PassWord,objUsers.Rights, out strErr);
                if (iRent == 1)
                {
                   
                    MainForm objEnter = new MainForm(objUsers.UserNo, objUsers.PassWord, objUsers.Rights);
                    objEnter.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("您输入的账号或密码错误，请重新输入！");
                    txtUserNo.Text = "";
                    txtPassWord.Text = "";
                    return;
                }
            }
            else
            {
                // //以学生方式登录
                Model.Users.Users objUsers = new Model.Users.Users();
                objUsers.UserNo = txtUserNo.Text.Replace("'", "''");
                objUsers.UserNo = objUsers.UserNo.Trim();
               
                objUsers.PassWord = txtPassWord.Text.Replace("'", "''");
                objUsers.PassWord = objUsers.PassWord.Trim();
              
                objUsers.Rights = 3;
                int iRent = objLogin.JudgeExist(objUsers.UserNo, objUsers.PassWord, objUsers.Rights, out strErr);
                if (iRent == 1)
                {
                  
                    MainForm objEnter = new MainForm(objUsers.UserNo, objUsers.PassWord, objUsers.Rights);
                    objEnter.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("您输入的账号或密码错误，请重新输入！");
                    txtUserNo.Text = "";
                    txtPassWord.Text = "";
                    return;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}