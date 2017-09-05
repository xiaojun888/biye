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
    public partial class ModifyTeaEduForm : Form
    {
        public string strTeaNo;
        public string strClassName;
        public string strCourseName;
        string OldClass;
        string OldCourse;
        int OldClassId;
        int OldCourseId;
        public ModifyTeaEduForm(string TeaNo, string ClName, string CoName)
        {
            strTeaNo = TeaNo.Replace("'", "''");
            strClassName = ClName.Replace("'", "''");
            strCourseName = CoName.Replace("'", "''");
            InitializeComponent();
        }

        private void ModifyTeaEduForm_Load(object sender, EventArgs e)
        {
            BindCourseId();
            BindClassId();
            txtTeaNo.Text = strTeaNo;
            LoadData();
        }
        void BindCourseId()                                                            //绑定课程信息
        {
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Course.Course objCourse = new Manage.Course.Course(strConnection);
            string strErr = "";
            DataTable objDataTable = new DataTable();
            int iRent = objCourse.SearchCourse1(out objDataTable, out strErr);
            if (iRent == 0)
            {
                MessageBox.Show(strErr);
                return;
            }
            else
            {
                cmbCourseName.DataSource = objDataTable;
                cmbCourseName.DisplayMember = "课程名称";
                cmbCourseName.ValueMember = "课程ID";
            }
        }
        void BindClassId()                                                             //绑定班级信息
        {
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Class.Class objClass = new Manage.Class.Class(strConnection);
            string strErr = "";
            DataTable objDataTable = new DataTable();
            int iRent = objClass.SearchClass1(out objDataTable, out strErr);
            if (iRent == 0)
            {
                MessageBox.Show(strErr);
                return;
            }
            else
            {
                cmbClassName.DataSource = objDataTable;
                cmbClassName.DisplayMember = "班级名称";
                cmbClassName.ValueMember = "班级Id";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string strErr = "";
            Model.Teacher_Course.Teacher_Course objTeCo = new Model.Teacher_Course.Teacher_Course();
            Model.Teacher_Class.Teacher_Class objTeCl = new Model.Teacher_Class.Teacher_Class();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Teacher_Course_Class.T_C_C objTCC = new Manage.Teacher_Course_Class.T_C_C(strConnection);
            objTeCl.ClassId = int.Parse(cmbClassName.SelectedValue.ToString());
            objTeCo.CourseId = int.Parse(cmbCourseName.SelectedValue.ToString());
            if (OldClass != cmbClassName.SelectedValue.ToString() && OldCourse != cmbCourseName.SelectedValue.ToString())
            {
                MessageBox.Show("只能在班级和课程中修改一个");
            }
            else if (OldClass == cmbClassName.SelectedValue.ToString() && OldCourse == cmbCourseName.SelectedValue.ToString())
            {
                MessageBox.Show("班级和课程没有改变，没有修改");
                this.Visible = false;
            }
            else
            {
                int iR = objTCC.JudgeClassCourse(objTeCo.CourseId, objTeCl.ClassId);
                if (iR == 0)
                {
                    MessageBox.Show("此班级的这门课程已经安排教师，请安排给其他的班级");
                }
                else
                {
                    if (OldClass == cmbClassName.SelectedValue.ToString() && OldCourse != cmbCourseName.SelectedValue.ToString())
                    {
                        int iRent = objTCC.ModifyTCC1(strTeaNo, OldClassId, OldCourseId, objTeCl, objTeCo, out strErr);
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
                    else if (OldCourse == cmbCourseName.SelectedValue.ToString() && OldClass != cmbClassName.SelectedValue.ToString())
                    {
                        int iRent = objTCC.ModifyTCC(strTeaNo, OldClassId, OldCourseId, objTeCl, objTeCo, out strErr);
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
                }
            }
        }
        public void LoadData()                                                     //加载修改教师的课程班级信息
        {
            string strErr = "";
            Model.Teacher.Teacher objTeacher = new Model.Teacher.Teacher();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;

            string strSql = "select distinct b.courseid ,a.classid  from  class_teacher a,teacher_course b where a.teaid=(select teaid from teacher where teano='" + strTeaNo + "'and type=1) ";
            strSql += " and a.teaid =b.teaid and a.type =1 and b.type =1 and a.classid =(select classid from class where classname ='" + strClassName + "' and type =1) ";
            strSql += " and b.courseid =(select courseid from course where coursename='" + strCourseName + "' and type =1)";
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
            OldClassId = int.Parse(dr["classid"].ToString());
            OldCourseId = int.Parse(dr["courseid"].ToString());
            cmbClassName.SelectedValue = dr["classid"].ToString();
            cmbCourseName.SelectedValue = dr["courseid"].ToString();
            OldClass = cmbClassName.SelectedValue.ToString();
            OldCourse = cmbCourseName.SelectedValue.ToString();
        }
    }
}