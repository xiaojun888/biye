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
          //��ȡ��ǰ�û��˺�
            lblUserNo.Text = struserno;
           
        }
        
        //�޸��û�����
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Login.Login objLogin = new Manage.Login.Login(strConnection);
            string strErr = "";
            Model.Users.Users objUsers = new Model.Users.Users();

            string struserno = this.lblUserNo.Text;
           
            if (this.txtNewPWD.Text == "" || this.txtConfirmPWD.Text == "")
            {
                MessageBox.Show("��ȷ����Ϣ�Ƿ���д������");
            }
            else
            {
                if (this.txtNewPWD.Text != this.txtConfirmPWD.Text)
                {
                    MessageBox.Show("������������벻һ��,���������룡");
                    this.txtNewPWD.Clear();
                    this.txtConfirmPWD.Clear();
                }
                else
                {
                  
                    if (this.txtNewPWD.Text == this.txtConfirmPWD.Text && this.txtNewPWD.Text.Length > 14)
                    {
                        MessageBox.Show("���볤��������14λ֮�ڣ�");
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
                        MessageBox.Show("�޸�����ɹ�");
                        this.Close();
                    }
                }

            }

        }

        //����
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtNewPWD.Clear();
            this.txtConfirmPWD.Clear();
        }

        //�˳�
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}