using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManage.Course
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }     

     
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Course.Course objManageCourse = new Manage.Course.Course(strConnection);
            string strErr = "";
            Model.Course.Course objCourse = new Model.Course.Course();

            objCourse.CourseNo = txtCourseNo.Text.Replace("'", "''");
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

            if (txtCourseName.Text == "" || txtCourseNo.Text=="")
            {
                MessageBox.Show("请将信息填写完整！");
            }
            else
            {
                int iCourseNo1 = objManageCourse.JudgeCourseNo(objCourse.CourseNo, out strErr);
                int iCourseNo2 = objManageCourse.JudgeCourseName(objCourse.CourseName, out strErr);
                if (iCourseNo1 == 0 && iCourseNo2== 0)
                {
                    int iRent = objManageCourse.AddCourse(objCourse, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("添加成功");
                        this.Visible = false;
                        //BindDataGridView();
                    }
                 }
                 else if (iCourseNo1 == 1 && iCourseNo2== 0)
                 {
                    MessageBox.Show("此课程编号已经存在，添加失败");
                 }
                 else if (iCourseNo1 == 0 && iCourseNo2 ==1)
                 {
                    MessageBox.Show("此课程名称已经存在，添加失败");
                 }
                 else
                 {
                    MessageBox.Show("当前课程编号和课程名称都已存在，添加失败");
                 }                
              
                               
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtCourseNo.Clear();
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