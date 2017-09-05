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
        void BindCourseId()                                                            //�󶨿γ���Ϣ
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
                cmbCourseName.DisplayMember = "�γ�����";
                cmbCourseName.ValueMember = "�γ�ID";
            }
        }
        void BindClassId()                                                             //�󶨰༶��Ϣ
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
                cmbClassName.DisplayMember = "�༶����";
                cmbClassName.ValueMember = "�༶Id";
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
                MessageBox.Show("ֻ���ڰ༶�Ϳγ����޸�һ��");
            }
            else if (OldClass == cmbClassName.SelectedValue.ToString() && OldCourse == cmbCourseName.SelectedValue.ToString())
            {
                MessageBox.Show("�༶�Ϳγ�û�иı䣬û���޸�");
                this.Visible = false;
            }
            else
            {
                int iR = objTCC.JudgeClassCourse(objTeCo.CourseId, objTeCl.ClassId);
                if (iR == 0)
                {
                    MessageBox.Show("�˰༶�����ſγ��Ѿ����Ž�ʦ���밲�Ÿ������İ༶");
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
                            MessageBox.Show("�޸ĳɹ�");
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
                            MessageBox.Show("�޸ĳɹ�");
                            this.Visible = false;
                        }
                    }
                }
            }
        }
        public void LoadData()                                                     //�����޸Ľ�ʦ�Ŀγ̰༶��Ϣ
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