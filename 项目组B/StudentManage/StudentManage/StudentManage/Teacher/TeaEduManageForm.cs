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

    public partial class TeaEduManageForm : Form
    {
        public int teaId;
        string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
        string strTeaNo;
        public TeaEduManageForm(string teaNo)
        {
            strTeaNo = teaNo;
            InitializeComponent();
        }

        private void TeaEduManageForm_Load(object sender, EventArgs e)
        {
            BindDataGridView();
            BindClassName();
            BindCourseName();
        }
        void BindDataGridView()
        {
            string strErr = "";
            DataTable objDataTable = new DataTable();
            Manage.Teacher_Course_Class.T_C_C objT_C_C = new Manage.Teacher_Course_Class.T_C_C(strConnection);
            int iRent = objT_C_C.SearchTCC(out objDataTable, out strErr);
            if (iRent == 0)
            {
                MessageBox.Show(strErr);
                return;
            }
            else
            {
                dataGridView.DataSource = objDataTable;
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strErr = "";
            DataTable objDataTable = new DataTable();
            Manage.Teacher_Course_Class.T_C_C objT_C_C = new Manage.Teacher_Course_Class.T_C_C(strConnection);
            string strTeaNo = txtTeaSearchNo.Text;
            strTeaNo = strTeaNo.Replace("%", @"\%");
            strTeaNo = strTeaNo.Replace("_", @"\_");
            strTeaNo = strTeaNo.Replace("'", @"\''");
            strTeaNo = strTeaNo.Trim();
            string strTeaName = txtTeaSearchName.Text;
            strTeaName = strTeaName.Replace("%", @"\%");
            strTeaName = strTeaName.Replace("_", @"\_");
            strTeaName = strTeaName.Replace("'", @"\''");
            strTeaName = strTeaName.Trim();
            string strClassName = txtClassSearchName.Text;
            strClassName = strClassName.Replace("%", @"\%");
            strClassName = strClassName.Replace("_", @"\_");
            strClassName = strClassName.Replace("'", @"\''");
            strClassName = strClassName.Trim();
            string strCourseName = txtCourseSearchName.Text;
            strCourseName = strCourseName.Replace("%", @"\%");
            strCourseName = strCourseName.Replace("_", @"\_");
            strCourseName = strCourseName.Replace("'", @"\''");
            strCourseName = strCourseName.Trim();
            int iRent = objT_C_C.SearchTCC1(strTeaNo, strTeaName, strCourseName, strClassName, out objDataTable, out strErr);
            if (iRent == 0)
            {
                MessageBox.Show(strErr);
                return;
            }
            else
            {
                if (objDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("没有符合你要查询的记录");
                }
                else
                {
                    dataGridView.DataSource = objDataTable;
                }
                txtTeaSearchNo.Text = "";
                txtTeaSearchName.Text = "";
                txtClassSearchName.Text = "";
                txtCourseSearchName.Text = "";
            }
        }
        void BindClassName()
        {
            string strErr = "";
            DataTable objDataTable = new DataTable();
            Manage.Class.Class objClass = new Manage.Class.Class(strConnection);
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
        void BindCourseName()
        {
            string strErr = "";
            DataTable objDataTable = new DataTable();
            Manage.Course.Course objCourse = new Manage.Course.Course(strConnection);
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

        private void btnAddTeaEdu_Click(object sender, EventArgs e)
        {
            if (cmbClassName.Text == "" || cmbCourseName.Text == "" || txtTeaNo.Text == "")
            {
                MessageBox.Show("教师、班级和课程不能为空，请先选择");
            }
            else
            {
                string strErr = "";
                DataTable objDataTable = new DataTable();
                Manage.Teacher_Course_Class.T_C_C objT_C_C = new Manage.Teacher_Course_Class.T_C_C(strConnection);
                Model.Teacher_Class.Teacher_Class objT_Class = new Model.Teacher_Class.Teacher_Class();
                Model.Teacher_Course.Teacher_Course objT_Course = new Model.Teacher_Course.Teacher_Course();
                objT_Class.ClassId = int.Parse(cmbClassName.SelectedValue.ToString());
                objT_Course.CourseId = int.Parse(cmbCourseName.SelectedValue.ToString());
                string strTeaNo1 = txtTeaNo.Text;
                teaId = objT_C_C.GetTeaId(strTeaNo1);

                int iRen = objT_C_C.JudgeTeaClassCourse(teaId, objT_Course.CourseId, objT_Class.ClassId);                               //判断增加的这条记录是否存在
                if (iRen == 0)
                {
                    MessageBox.Show("此记录已经存在");
                }
                else
                {
                    int iR = objT_C_C.JudgeClassCourse(objT_Course.CourseId, objT_Class.ClassId);                                              //判断此班级的这门课程是否已经安排教师
                    if (iR == 0)
                    {
                        MessageBox.Show("此班级的这门课程已经安排教师，请安排给其他班级");
                    }
                    else
                    {

                        int iRent = objT_C_C.AddTeacherC_C(objT_Course, objT_Class, teaId, out strErr);
                        if (iRent == 0)
                        {
                            MessageBox.Show(strErr);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("添加成功");
                            BindDataGridView();
                        }
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int i = dataGridView.SelectedRows.Count;
            if (i == 0)
            {
                MessageBox.Show("请先选中你要删除的一行");
            }
            else
            {
                //if (DialogResult.Yes == MessageBox.Show("真的要删除吗？", "确认退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                //{
                    for (int j = 0; j < dataGridView.SelectedRows.Count; j++)
                    {
                        Manage.Teacher_Course_Class.T_C_C objT_C_C = new Manage.Teacher_Course_Class.T_C_C(strConnection);
                        Model.Teacher_Class.Teacher_Class objT_Class = new Model.Teacher_Class.Teacher_Class();
                        Model.Teacher_Course.Teacher_Course objT_Course = new Model.Teacher_Course.Teacher_Course();
                        objT_Class.ClassId = int.Parse(cmbClassName.SelectedValue.ToString());
                        objT_Course.CourseId = int.Parse(cmbCourseName.SelectedValue.ToString());
                        string strTeaNo1 = dataGridView.SelectedCells[0].Value.ToString();
                        teaId = objT_C_C.GetTeaId(strTeaNo1);

                        string strTeacherNo = dataGridView.SelectedRows[j].Cells["教师编号"].Value.ToString();
                        string strClassNo = dataGridView.SelectedRows[j].Cells["班级编号"].Value.ToString();
                        string strCourseNo = dataGridView.SelectedRows[j].Cells["课程编号"].Value.ToString();
                        string strErr = "";
                        
                        int j1 = objT_C_C.JudgeClassCourse(strCourseNo,strClassNo ,out strErr);
                        int j2 = objT_C_C.JudgeTeaClass(strTeacherNo, strClassNo, out strErr);
                        int j3 = objT_C_C.JudgeTeaCourse(strTeacherNo, strCourseNo, out strErr);

                        int iRent = objT_C_C.DelTCC(strTeacherNo, strClassNo, strCourseNo, out strErr);
                        if (j1 > 1)
                        {
                            for (int sum1 = 0; sum1 < j1-1; sum1++)
                            {
                                int iRent1 = objT_C_C.AddClassCourse(objT_Course, objT_Class, teaId, out strErr);
                                if (iRent1 == 0)
                                {
                                    MessageBox.Show(strErr);
                                    return;
                                }                                
                            }
                        }
                        if (j2 > 1)
                        {
                            for (int sum2 = 0; sum2 < j2 - 1; sum2++)
                            {
                                int iRent2 = objT_C_C.AddTeacherClass(objT_Class, teaId, out strErr);
                                if (iRent2 == 0)
                                {
                                    MessageBox.Show(strErr);
                                    return;
                                }                                
                            }
                        }
                        if (j3 > 1)
                        {
                            for (int sum3 = 0; sum3< j3 - 1; sum3++)
                            {
                                int iRent3= objT_C_C.AddTeacherCourse(objT_Course, teaId, out strErr);
                                if (iRent3 == 0)
                                {
                                    MessageBox.Show(strErr);
                                    return;
                                }
                            }
                        }
                        

                        if (iRent == 0)
                        {
                            MessageBox.Show(strErr);
                            return;
                        }
                        BindDataGridView();
                    }
                    MessageBox.Show("删除成功");
                }
            //}
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int i = 1; string strNo = "";
            StudentManage.Teacher.TeaManageForm TeaManageForm = new TeaManageForm(i, strNo);
            TeaManageForm.menuAddTea.Visible = false;
            TeaManageForm.menuDelTea.Visible = false;
            TeaManageForm.menuModifyTea.Visible = false;
            TeaManageForm.btnDel.Visible = false;
            TeaManageForm.menuTeaEdu.Visible = false;
            TeaManageForm.btnModify.Text = "选　择";
            TeaManageForm.ShowDialog(this);
        }

        private void menuMotifyTeaEdu_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选中一行");
            }
            else
            {
                string TeaNo = dataGridView.SelectedRows[0].Cells["教师编号"].Value.ToString();
                //TeaNo = TeaNo.Replace("'", "''");
                string ClassName = dataGridView.SelectedRows[0].Cells["班级名称"].Value.ToString();
                //ClassName = ClassName.Replace("'", "''");
                string CourseName = dataGridView.SelectedRows[0].Cells["课程名称"].Value.ToString();
                //CourseName = CourseName.Replace("'", "''");
                ModifyTeaEduForm objMTE = new ModifyTeaEduForm(TeaNo, ClassName, CourseName);
                objMTE.ShowDialog();
                BindDataGridView();
            }
        }

        private void menuExit_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}