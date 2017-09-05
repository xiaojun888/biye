using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace StudentManage.Student
{
    public partial class ModifyStuForm : Form
    {
        //public int iID;
        public string stu;
        public string studentno;
        public ModifyStuForm(string strStu)
        {
            InitializeComponent();
            //iID = ID; 
            stu = strStu.Replace("'", "''");
        }

        void BindClassId()
        {
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Class.Class objClass = new Manage.Class.Class(strConnection);
            string strErr = "";
            DataTable objDataTable = new DataTable();
            int iRent = objClass.SearchClass3(out objDataTable, out strErr);
            if (iRent == 0)
            {
                MessageBox.Show(strErr);
                return;
            }
            else
            {
                cmbClassId.DataSource = objDataTable;
                cmbClassId.DisplayMember = "ClassName";
                cmbClassId.ValueMember = "ClassId";
            }
        }


        public void LoadData()
        {
            string strErr = "";
            Model.Student.Student objStudent = new Model.Student.Student();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            string strSql = "select * from student where stuno='" + stu + "' and type =1";
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
            studentno = this.txtStuNo.Text = dr["StuNo"].ToString();
            this.txtStuName.Text = dr["StuName"].ToString();
            this.txtAddress.Text = dr["StuAddress"].ToString();
            this.txtRemark.Text = dr["Remark"].ToString();
            this.dtpBirthDate.Text = dr["BirthDate"].ToString();
            this.dtpEntranceTime.Text = dr["EntranceTime"].ToString();
            //string str =dr["ClassId"].ToString ();
            //this.cmbClassId.ValueMember= dr["ClassId"].ToString ();
            //this.cmbClassId.DisplayMember =dr["ClassName"];
            //this.txtStuTel.Text = dr["StuTel"].ToString();

            this.cmbClassId.SelectedValue = dr["ClassId"].ToString();
            if (dr["sex"].ToString() == "男")
            {
                this.rabMan.Checked = true;
            }
            else
            {
                this.rabWoman.Checked = true;
            }
        }


        private void ModifyStuForm_Load(object sender, EventArgs e)
        {
            BindClassId();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strErr = "";
            Model.Student.Student objStudent = new Model.Student.Student();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Student.Student objStu = new Manage.Student.Student(strConnection);
            objStudent.StuNo = txtStuNo.Text.Replace("'", "''");
            objStudent.StuNo = objStudent.StuNo.Trim();
            objStudent.StuName = txtStuName.Text.Replace("'", "''");
            objStudent.StuName = objStudent.StuName.Trim();
            if (objStudent.StuName == "" || objStudent.StuNo == "")
            {
                MessageBox.Show("请将信息填写完整！");
            }
            else
            {

                if (this.rabWoman.Checked == true)
                {
                    objStudent.Sex = "女";
                }
                else
                {
                    objStudent.Sex = "男";
                }
                objStudent.BirthDate = dtpBirthDate.Value;
                objStudent.EntranceTime = dtpEntranceTime.Value;
                //objStudent.StuTel = txtStuTel.Text.Replace("'", "''");
                if (this.txtStuTel.Text != "")
                {
                    string patten = @"(13\d{9}(;13\d{9})*)|(15\d{9}(;15\d{9})*)|(\(\d{3,4}\)|\d{3,4}-)?\d{7,8}(;(\(\d{3,4}\)|\d{3,4}-)?\d{7,8})*";
                    Regex r = new Regex(patten);
                    Match m = r.Match(txtStuTel.Text);
                    if (!m.Success)
                    {
                        MessageBox.Show("请输入正确的电话号码");
                        this.txtStuTel.Text = "";
                        this.txtStuTel.Focus();
                        return;
                    }
                    else
                    {
                        objStudent.StuTel = txtStuTel.Text.ToString();
                    }

                }

                objStudent.StuAddress = txtAddress.Text.Replace("'", "''");
                objStudent.Remark = txtRemark.Text.Replace("'", "''");
                objStudent.ClassId = int.Parse(cmbClassId.SelectedValue.ToString());
                if (studentno == objStudent.StuNo)
                {
                    int iRent = objStu.ModifyStu(stu, studentno, objStudent, out strErr);
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
                    int iExist = objStu.JudgeStuNo(objStudent.StuNo);
                    int i = objStu.JudgeStuNoLikeTeaNo(objStudent.StuNo);
                    if (iExist == 0 && i == 0)
                    {
                        int iRent = objStu.ModifyStu(stu, studentno, objStudent, out strErr);
                        if (iRent == 0)
                        {
                            MessageBox.Show(strErr);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("修改成功,同时此学生的账号和密码也修改成功！");
                            this.Visible = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("已经存在一个编号相同的学生或者教师，修改失败");
                        txtStuNo.Text = studentno;
                    }

                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtStuNo.Clear();
            this.txtStuName.Clear();
            this.rabMan.Checked = true;
            this.txtStuTel.Clear();
            this.txtRemark.Clear();
            this.txtAddress.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }



    }
}