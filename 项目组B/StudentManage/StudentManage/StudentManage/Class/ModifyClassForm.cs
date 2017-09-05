using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManage.Class
{
    public partial class ModifyClassForm : Form
    {
        public string classNo;
        public string className;

        public ModifyClassForm(string strClassNo)
        {
            InitializeComponent();
            classNo = strClassNo;
        }

        private void ModifyClassForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            string strErr = "";
            Model.Class.Class objClass = new Model.Class.Class();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            string strSql = "select * from class where classNo ='" + classNo.Replace("'", "''") + "'";
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
            className = this.txtClassName.Text = dr["ClassName"].ToString();
            this.txtClassNo.Text = dr["ClassNo"].ToString();
            this.txtRemark.Text = dr["Remark"].ToString();

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)　//保存修改后的班级。如果修改后的班级编号和名称有相同的，修改失败
        {
            string strErr = "";
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Model.Class.Class objClass = new Model.Class.Class();
            Manage.Class.Class objClassMan = new Manage.Class.Class(strConnection);
            objClass.ClassNo = txtClassNo.Text.Replace("'", "''");
            objClass.ClassNo = objClass.ClassNo.Trim();
            objClass.ClassName = txtClassName.Text.Replace("'", "''");
            objClass.ClassName = objClass.ClassName.Trim();
            objClass.Remark = txtRemark.Text.Replace("'", "''");
            objClass.Remark = objClass.Remark.Trim();
            string strClassNo = classNo.Replace("'", "''");
            strClassNo = strClassNo.Trim();
            string strClassName = className.Replace("'", "''");
            strClassName = strClassName.Trim();
            if (objClass.ClassName == "" || objClass.ClassNo == "")
            {
                MessageBox.Show("请将信息填写完整！");
            }
            else
            {
                int i = objClassMan.JudgeClassNo(objClass);
                int j = objClassMan.JudgeClassName(objClass);
                if (strClassNo == objClass.ClassNo && strClassName == objClass.ClassName)
                {
                    int iRent = objClassMan.ModifyClass(classNo, objClass, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {

                        this.Visible = false;
                    }
                }
                else if (strClassNo != objClass.ClassNo && strClassName == objClass.ClassName)
                {

                    if (i == 0)
                    {
                        int iRent = objClassMan.ModifyClass(classNo, objClass, out strErr);
                        if (iRent == 0)
                        {
                            MessageBox.Show(strErr);
                            return;
                        }
                        else
                        {

                            this.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("当前班级编号已经存在，修改失败");
                        txtClassNo.Text = classNo;
                    }

                }
                else if (strClassNo == objClass.ClassNo && strClassName != objClass.ClassName)
                {
                    if (j == 0)
                    {
                        int iRent = objClassMan.ModifyClass(classNo, objClass, out strErr);
                        if (iRent == 0)
                        {
                            MessageBox.Show(strErr);
                            return;
                        }
                        else
                        {

                            this.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("当前班级名称已经存在，修改失败");
                        txtClassName.Text = className;
                    }
                }
                else
                {
                    if (i == 0 && j == 0)
                    {
                        int iRent = objClassMan.ModifyClass(classNo, objClass, out strErr);
                        if (iRent == 0)
                        {
                            MessageBox.Show(strErr);
                            return;
                        }
                        else
                        {
                            this.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("当前班级编号和名称都已经存在，修改失败");
                        txtClassNo.Text = classNo;
                    }
                }
            }
        }
    }
}