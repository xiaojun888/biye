using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManage.Login
{
    public partial class ModifyNewsForm : Form
    {
        public int iRights;
        public string strUserNumber;
        public string userno;
        public ModifyNewsForm(int rights,string struserNo)
        {
            InitializeComponent();
            iRights= rights ;
            strUserNumber = struserNo.Replace("'", "''");
        }

        private void ModifyNewsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            string strErr = "";
            Model.Users.Users objUsers = new Model.Users.Users();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            string strSql = "select * from Users where UserNo='" + strUserNumber + "' and Type=1";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConnection;
            conn.Open();
            SqlCommand sqlcomd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            try
            {
                da.Fill(ds);
            }
            catch (Exception exce)
            {
                strErr = exce.ToString();
            }
            finally
            {
                conn.Close();
            }
           
            DataRow dr = ds.Tables[0].Rows[0];
            userno = this.txtUserNo.Text = dr["UserNo"].ToString();
            this.txtUserName.Text = dr["UserName"].ToString();
            this.txtPWD.Text = dr["PassWord"].ToString();
            this.txtRights.Text = dr["Rights"].ToString();
        }
        //修改用户名称 用户密码
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strErr = "";
            string strUserNo;
            Model.Users.Users objUsers = new Model.Users.Users();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Login.Login objLogin = new Manage.Login.Login(strConnection);
           strUserNo = objUsers.UserNo = txtUserNo.Text.Replace("'", "''");
            objUsers.UserNo = objUsers.UserNo.Trim();

            objUsers.UserName = txtUserName.Text.Replace("'", "''");
            objUsers.UserName= objUsers.UserName.Trim();

            objUsers.PassWord = txtPWD.Text.Replace("'", "''");
            objUsers.PassWord= objUsers.PassWord.Trim();

            objUsers.Rights = int.Parse(txtRights.Text.ToString());
           
            if (objUsers.UserNo == "" || objUsers.UserName == "")
            {
                MessageBox.Show("请将信息填写完整！");
            }
            else
            {
                if (userno == objUsers.UserNo)
                {
                    int iRent = objLogin.ModifyUser(iRights,strUserNo, userno, objUsers, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("修改成功！");
                        this.Visible = false;
                    }
                }
                else
                {
                    int iExist = objLogin.JudgeUserNo(objUsers.UserNo);                   
                    if (iExist == 0 )
                    {
                        int iRent = objLogin.ModifyUser(iRights,strUserNo,userno,objUsers, out strErr);
                        if (iRent == 0)
                        {
                            MessageBox.Show(strErr);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("修改成功！");
                            this.Visible = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("此帐号已存在，修改失败");
                        txtUserNo.Text = userno;
                    }

                }
            }
        }
            
      
        //清除重置
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtUserNo.Clear();
            this.txtUserName.Clear();
            this.txtPWD.Clear();
          
        }

        //退出当前界面
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

       
    }
}