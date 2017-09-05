using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManage.Teacher
{
    public partial class ModifyTeaForm : Form
    {
        public string strTeaNo;
        public string strTeaName;
        public ModifyTeaForm(string teaNo)
        {
            InitializeComponent();
            strTeaNo = teaNo;
        }

        private void ModifyTeaForm_Load(object sender, EventArgs e)
        {
            Data_Load();
        }
        public void Data_Load()
        {
            string strErr = "";
            Model.Teacher.Teacher objTeacher = new Model.Teacher.Teacher();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            string strSql = "select * from teacher where teaNo ='" + strTeaNo.Replace("'", "''") + "'";
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = strConnection;
            sqlCon.Open();
            SqlCommand sqlcomd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(strSql, sqlCon);
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
                sqlCon.Close();
            }
            DataRow dr = ds.Tables[0].Rows[0];
            txtTeaNo.Text = dr["teaNo"].ToString();
            strTeaName = txtTeaName.Text = dr["teaName"].ToString();
            nudAge.Text = dr["age"].ToString();
            cmbRank.SelectedItem = dr["rank"].ToString();
            cmbDegree.SelectedItem = dr["Degree"].ToString();
            txtAddress.Text = dr["TeaAddress"].ToString();
            txtRemark.Text = dr["Remark"].ToString();
            txtTel.Text = dr["TeaTel"].ToString();
            string woman = dr["sex"].ToString();
            if (woman == "女")
            {
                rdbWoman.Checked = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string strErr;
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Model.Teacher.Teacher objTea = new Model.Teacher.Teacher();
            Manage.Teacher.Teacher objTeaManage = new Manage.Teacher.Teacher(strConnection);
            objTea.TeaNo = txtTeaNo.Text.Replace("'", "''");
            objTea.TeaNo = txtTeaNo.Text.Trim();
            objTea.TeaName = txtTeaName.Text.Replace("'", "''");
            objTea.TeaName = txtTeaName.Text.Trim();
            objTea.Age = int.Parse(nudAge.Value.ToString());
            objTea.Rank = cmbRank.Text;
            objTea.TeaTel = txtTel.Text.Replace("'", "''");
            objTea.TeaTel = txtTel.Text.Trim();
            objTea.TeaAddress = txtAddress.Text.Replace("'", "''");
            objTea.TeaAddress = txtAddress.Text.Trim();
            objTea.Degree = cmbDegree.Text;
            objTea.Remark = txtRemark.Text.Replace("'", "''");
            objTea.Remark = txtRemark.Text.Trim();


            if (rdbMan.Checked == true)
            {
                objTea.Sex = "男";
            }
            else
            {
                objTea.Sex = "女";
            }
            if (txtTeaNo.Text == "" || txtTeaName.Text == "")
            {
                MessageBox.Show("教师编号和姓名不能为空");
                txtTeaNo.Text = strTeaNo;
                txtTeaName.Text = strTeaName;
            }
            else if (objTea.TeaNo == strTeaNo)
            {
                int iRent = objTeaManage.ModifyTea(strTeaNo, objTea, out strErr);
                if (iRent == 0)
                {
                    MessageBox.Show(strErr);
                    return;
                }
                else
                {
                    MessageBox.Show("修改成功");
                    this.Visible = false;
                }
            }
            else
            {
                int j = objTeaManage.JudgeTeaNo(objTea.TeaNo);
                int i = objTeaManage.JudgeTeaNoLikeStuNo(objTea.TeaNo);
                if (i == 1 && j == 1)
                {
                    int iRent = objTeaManage.ModifyTea(strTeaNo, objTea, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("修改成功");
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("已经存在一个编号相同的教师或者学生，修改失败");
                    txtTeaNo.Text = strTeaNo;
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}