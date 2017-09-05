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
    public partial class CourseManageForm : Form
    {
        public int iRight;
        public string strUserNo;
        public CourseManageForm(int iRights,string UserNo)       
        {
            InitializeComponent();
            iRight = iRights;
            strUserNo = UserNo; 
        }

        private void CourseManageForm_Load(object sender, EventArgs e)
        {
            //BindDataGridView();
            if (iRight == 1)
            {
                BindDataGridView();
            }
            else if (iRight == 2)
            {
                menuAddCourse.Visible = false;
                menuDelCourse.Visible = false;
                menuModifyCourse.Visible = false;
                btnDel.Visible = false;
                btnModify.Visible = false;
                BindDataGridView();
            }
            else
            {
                txtClassName.Visible = false;
                lblClassName.Visible = false;
                BindDataGridView();
                menuAddCourse.Visible = false;
                menuDelCourse.Visible = false;
                menuModifyCourse.Visible = false;
                btnDel.Visible = false;
                btnModify.Visible = false;
            }          
        }

        void BindDataGridView()
        {
            string strErr = "";
            DataTable objDataTable = new DataTable();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Course.Course objManageCourse = new Manage.Course.Course(strConnection);
            int iRent = objManageCourse.SearchCourseAll(iRight,strUserNo,out objDataTable, out strErr);
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

        private void menuAddCourse_Click(object sender, EventArgs e)
        {
            StudentManage.Course.AddCourseForm AddCourseForm = new AddCourseForm();
            AddCourseForm.ShowDialog();
            BindDataGridView();
        }

        private void menuModifyCourse_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要修改的行");
            }
            else if (dataGridView.SelectedRows.Count == 1)
            {
                //int iCourseId = int.Parse(dataGridView.SelectedRows[0].Cells["课程ID"].Value.ToString());
                string strCourseNo =dataGridView.SelectedRows[0].Cells["课程编号"].Value.ToString();
                StudentManage.Course.ModifyCourseForm ModifyCourseForm = new ModifyCourseForm(strCourseNo);
                ModifyCourseForm.ShowDialog();
                BindDataGridView();
            }
            else
            {
                MessageBox.Show("一次只能修改一行");
            }
        }

        private void menuSearchCourse_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void menuDelCourse_Click(object sender, EventArgs e)
        {
            btnDel_Click(sender, e);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            menuModifyCourse_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strCourseNo = txtCourseNo.Text.Replace(@"\", @"\\");
            strCourseNo = strCourseNo.Replace("%", @"\%");
            strCourseNo = strCourseNo.Replace("_", @"\_");
            strCourseNo = strCourseNo.Replace("'", @"\''");
            strCourseNo = strCourseNo.Trim();
            string strCourseName = txtCourseName.Text.Replace(@"\", @"\\");
            strCourseName = strCourseName.Replace("%", @"\%");
            strCourseName = strCourseName.Replace("_", @"\_");
            strCourseName = strCourseName.Replace("'", @"\''");
            strCourseName = strCourseName.Trim();
            string strClassName = txtClassName.Text.Replace(@"\", @"\\");
            strClassName = strClassName.Replace("%", @"\%");
            strClassName = strClassName.Replace("_", @"\_");
            strClassName = strClassName.Replace("'", @"\''");
            strClassName = strClassName.Trim();
           
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Course.Course objManageCourse = new Manage.Course.Course(strConnection);

            
            string strErr = "";

            if (strCourseNo == "" && strCourseName == "" && strClassName == "")
            {
                BindDataGridView();
            }
            else
            {
                DataTable objDataTable = new DataTable();
                //DataTable objDataTable = new DataTable();
                int iRent = objManageCourse.SearchCourse(iRight, strUserNo, strCourseNo, strCourseName, strClassName, out objDataTable, out strErr);
                if (iRent == 0)
                {
                    MessageBox.Show(strErr);
                }
                else
                {
                    if (objDataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("没有您要查询的记录");
                        dataGridView.DataSource = objDataTable;
                    }
                    else
                    {
                        dataGridView.DataSource = objDataTable;
                    }

                }
                txtCourseNo.Text = "";
                txtCourseName.Text = "";
                txtClassName.Text = "";               
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选中要删除的行");
            }
            else
            {
                string strErr = "";
                string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
                Manage.Course.Course objManageCourse = new Manage.Course.Course(strConnection);               
                for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                {
                    //int iCourseId = int.Parse(dataGridView.SelectedRows[i].Cells["课程ID"].Value.ToString());
                    string strCourseNo =dataGridView.SelectedRows[i].Cells["课程编号"].Value.ToString();
                    //int iRent = objManageCourse.DelCourse(iCourseId,out strErr);
                    int iRent = objManageCourse.DelCourse(strCourseNo,out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                }
                BindDataGridView();

            }
        }

       
    }
}