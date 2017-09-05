using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace StudentManage.Score
{
    public partial class AddScoreForm : Form
    {

        DataTable objDataTable = new DataTable();
        public int iRight;
        public string UserNo;
        string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;

        public AddScoreForm()
        {
            InitializeComponent();
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //添加成绩信息
        private void btnSave_Click(object sender, EventArgs e)
        {
            string strErr = "";
            Model.Class.Class objClass1 = new Model.Class.Class();
            Model.Student.Student objStudent1 = new Model.Student.Student();
            Model.Course.Course objCourse1 = new Model.Course.Course();
            objClass1.ClassNo = cmbClassName.SelectedValue .ToString();
            objStudent1.StuId = int.Parse(cmbStuNo.SelectedValue .ToString());
            objCourse1.CourseId = int.Parse(cmbCourseName.SelectedValue .ToString());
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Score.Score objSco = new Manage.Score.Score(strConnection);

                int i = objSco.Judge(objStudent1, objCourse1);　　　　// 判断是否存在所选的成绩，如果为0，表示不存在记录，可以增加。为1表示存在记录，不能重复插入成绩。
                if (i == 0)
                {
                    Model.Score.Score objScore = new Model.Score.Score();
                    Model.Student.Student objStudent = new Model.Student.Student();
                    Model.Course.Course objCourse = new Model.Course.Course();
                   
                    objScore.CourseId = int.Parse(cmbCourseName.SelectedValue.ToString());
                    objScore.StuId = int.Parse(cmbStuNo.SelectedValue.ToString());
                    objScore.score = float.Parse(nudScore.Value.ToString());
                    objScore.StuName = txtStuName.Text;
                    int iRent = objSco.AddScore(objScore, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("添加成功");
                        this.Visible = false;
                        BindClassId();
                        BindStuId();
                        BindCourseId();
                    }
                }
                else
                {
                    MessageBox.Show("不能重复插入分数");
                }
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
                cmbClassName.DataSource = objDataTable;
                cmbClassName.DisplayMember = "ClassName";
                cmbClassName.ValueMember = "ClassId";

            }
        }

        void BindStuId()
        {
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Student.Student objStu = new Manage.Student.Student(strConnection);
            string strErr = "";
            DataTable objDataTable = new DataTable();
            int iRent = objStu.SearchStudent3(out objDataTable, out strErr);
            if (iRent == 0)
            {
                MessageBox.Show(strErr);
                return;
            }
            else
            {
                cmbStuNo.DataSource = objDataTable;
                cmbStuNo.DisplayMember = "StuNo";
                cmbStuNo.ValueMember = "StuId";

            }
        }

        void BindCourseId()
        {
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Course.Course objCourse = new Manage.Course.Course(strConnection);
            string strErr = "";
            DataTable objDataTable = new DataTable();
            int iRent = objCourse.SearchCourse3(out objDataTable, out strErr);
            if (iRent == 0)
            {
                MessageBox.Show(strErr);
                return;
            }
            else
            {
                cmbCourseName.DataSource = objDataTable;
                cmbCourseName.DisplayMember = "CourseName";
                cmbCourseName.ValueMember = "CourseId";
            }
        }

      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            BindClassId();
            BindStuId();
            BindCourseId();
        }




    }
}