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
        //������Ƥ��
        
        Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();
        public LoginInterfaceForm()
        {
            InitializeComponent();
            //ѡ��Ƥ���ļ�
            skin.SkinFile = System.Environment.CurrentDirectory + "\\skin\\" + "Wave.ssk";
            //���ǰƤ��
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
                //�Թ���Ա��ݵ�¼
                //�ж�������û����������Ƿ���ȷ,��ȷ���� MainForm����,������ʾ��������˺Ż������������������
                if (txtUserNo.Text == "system" && txtPassWord.Text == "521521")
                {
                    objUsers.Rights = 1;
                    MainForm objEnter = new MainForm(objUsers.UserNo, objUsers.PassWord, objUsers.Rights);
                    this.Visible = false;
                    objEnter.Show();
                }
                else
                {
                    
                    MessageBox.Show("��������˺Ż�����������������룡");
                    txtUserNo.Text = "";
                    txtPassWord.Text = "";
                    return;
                }
            }
            ////�Խ�ʦ��ݵ�¼
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
                    MessageBox.Show("��������˺Ż�����������������룡");
                    txtUserNo.Text = "";
                    txtPassWord.Text = "";
                    return;
                }
            }
            else
            {
                // //��ѧ����ʽ��¼
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
                    MessageBox.Show("��������˺Ż�����������������룡");
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