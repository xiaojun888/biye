using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManage.Course
{
    public partial class ModifyCourseForm : Form
    {
        public string strCourseNumber;
        public string courseno;
        public string coursename;        
        public ModifyCourseForm(string strCourseno)
        {
            InitializeComponent();
            strCourseNumber = strCourseno.Replace("'", "''");
        }


        private void ModifyCourseForm_Load(object sender, EventArgs e)
        {
             LoadData();
        }

        public void LoadData()
        {
            string strErr = "";
            Model.Course.Course objCourse = new Model.Course.Course();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            string strSql = "select * from Course where CourseNo ='" + strCourseNumber + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConnection;
            conn.Open();
            SqlCommand sqlcomd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            try
            {
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
            }
            finally
            {
                conn.Close();
            }
            DataRow dr = ds.Tables[0].Rows[0];           
            courseno = this.txtCourseNo1.Text = dr["CourseNo"].ToString();
            courseno = courseno.Trim();
            coursename = this.txtCourseName.Text = dr["CourseName"].ToString();
            coursename = coursename.Trim();
            this.txtPoints.Text = dr["Points"].ToString();
            this.txtRemark.Text = dr["Remark"].ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Course.Course objManageCourse = new Manage.Course.Course(strConnection);
            string strErr = "";
            Model.Course.Course objCourse = new Model.Course.Course();

            objCourse.CourseNo = txtCourseNo1.Text.Replace("'", "''");
            objCourse.CourseNo = objCourse.CourseNo.Trim();
            objCourse.CourseName = txtCourseName.Text.Replace("'", "''");
            objCourse.CourseName = objCourse.CourseName.Trim();
            //objCourse.Points = float.Parse(this.txtPoints.Text.ToString().Replace("'", "''"));
            //objCourse.Points = objCourse.Points.Trim();
            objCourse.Remark = txtRemark.Text.Replace("'", "''");
            objCourse.Remark = objCourse.Remark.Trim();

            if (this.txtPoints.Text != "")
            {
                try
                {
                    objCourse.Points = float.Parse(this.txtPoints.Text.ToString().Replace("'", "''"));
                    if (this.txtPoints.Text.IndexOf('.') == 0)
                    {
                        MessageBox.Show("小数点之前没有数字");
                        return;
                    }
                    if (this.txtPoints.Text.Length - this.txtPoints.Text.IndexOf('.') - 1 == 0)
                    {
                        MessageBox.Show("小数点后没有数字");
                        return;
                    }
                    else
                    {
                        objCourse.Points = float.Parse(this.txtPoints.Text.ToString().Replace("'", "''"));
                    }
                    if (objCourse.Points < 0)
                    {
                        MessageBox.Show("请输入正数");
                        return;
                    }
                }

                catch
                {

                    MessageBox.Show("请输入正确的学分");
                    this.txtPoints.Text = "";
                    this.txtPoints.Focus();
                    return;
                }
            }
            //objCourse.CourseNo = txtCourseNo.Text.Replace("'", "''");
            //objCourse.CourseNo = objCourse.CourseNo.Trim();
            //objCourse.CourseName = txtCourseName.Text.Replace("'", "''");
            //objCourse.CourseName = objCourse.CourseName.Trim();

            //objCourse.Points = float.Parse(this.txtPoints.Text.ToString().Replace("'", "''"));
            //objCourse.Points = objCourse.Points.Trim();

            //objCourse.Remark = txtRemark.Text.Replace("'", "''");
            //objCourse.Remark = objCourse.Remark.Trim();
            if (txtCourseName.Text == "" || txtCourseNo1.Text=="")
            {
                MessageBox.Show("请将课程编号和名称填写完整");
            }
            else if (courseno == objCourse.CourseNo && coursename == objCourse.CourseName)
                {
                    int iRent = objManageCourse.ModifyCourse(strCourseNumber, objCourse, out strErr);
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
                int iCourseNo1 = objManageCourse.JudgeCourseNo(objCourse.CourseNo, out strErr);
                int iCourseNo2 = objManageCourse.JudgeCourseName(objCourse.CourseName, out strErr);
                
                if (courseno != objCourse.CourseNo && coursename == objCourse.CourseName)
                {

                    if (iCourseNo1 == 0)
                    {
                        int iRent = objManageCourse.ModifyCourse(strCourseNumber, objCourse, out strErr);
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
                        MessageBox.Show("当前课程编号已经存在，修改失败");
                        txtCourseNo.Text = courseno;
                    }

                }
                else if (courseno == objCourse.CourseNo && coursename != objCourse.CourseName)
                {
                    if (iCourseNo2 == 0)
                    {
                        int iRent = objManageCourse.ModifyCourse(strCourseNumber, objCourse, out strErr);
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
                        MessageBox.Show("当前课程名称已经存在，修改失败");
                        txtCourseNo.Text = courseno;
                    }
                }
                else
                {
                    if (iCourseNo1 == 0 && iCourseNo2 == 0)
                    {
                        int iRent = objManageCourse.ModifyCourse(strCourseNumber, objCourse, out strErr);
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
                        MessageBox.Show("当前课程编号和名称都已经存在，修改失败");
                        txtCourseNo.Text = courseno;
                    }

                }

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtCourseNo1.Clear();
            this.txtCourseName.Clear();
            this.txtPoints.Clear();
            this.txtRemark.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }        

      
    }
}