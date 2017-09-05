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
                        MessageBox.Show("С����֮ǰû������");
                        return;
                    }
                    if (this.txtPoints.Text.Length - this.txtPoints.Text.IndexOf('.') - 1 == 0)
                    {
                        MessageBox.Show("С�����û������");
                        return;
                    }
                    else
                    {
                        objCourse.Points = float.Parse(this.txtPoints.Text.ToString().Replace("'", "''"));
                    }
                    if (objCourse.Points < 0)
                    {
                        MessageBox.Show("����������");
                        return;
                    }
                }

                catch
                {

                    MessageBox.Show("��������ȷ��ѧ��");
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
                MessageBox.Show("�뽫��Ϣ��д������");
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
                        MessageBox.Show("��ӳɹ�");
                        this.Visible = false;
                        //BindDataGridView();
                    }
                 }
                 else if (iCourseNo1 == 1 && iCourseNo2== 0)
                 {
                    MessageBox.Show("�˿γ̱���Ѿ����ڣ����ʧ��");
                 }
                 else if (iCourseNo1 == 0 && iCourseNo2 ==1)
                 {
                    MessageBox.Show("�˿γ������Ѿ����ڣ����ʧ��");
                 }
                 else
                 {
                    MessageBox.Show("��ǰ�γ̱�źͿγ����ƶ��Ѵ��ڣ����ʧ��");
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