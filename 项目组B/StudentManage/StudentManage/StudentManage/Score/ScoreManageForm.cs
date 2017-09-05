using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManage.Score
{
    public partial class ScoreManageForm : Form
    {
        DataTable objDataTable = new DataTable();
        public int iRight;
        public string strUserNo;
        string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;

        public ScoreManageForm(int iRights, string UserNo)
        {
            InitializeComponent();
            iRight = iRights;
            strUserNo = UserNo;
        }

        void BindDataGridViewAdmin()
        {
            string strErr = "";
            Manage.Score.Score objScore = new Manage.Score.Score(strConnection);
            DataTable objDataTable = new DataTable();
            int iRent = objScore.SearchScore(out objDataTable, out strErr);
            if (iRent == 0)
            {
                MessageBox.Show(strErr);
                return;
            }
            else
            {
               dataGridView . DataSource = objDataTable;
            }

        }

        void BindDataGridViewTea()
        {
            string strErr = "";
            Manage.Score.Score objScore = new Manage.Score.Score(strConnection);
            DataTable objDataTable = new DataTable();
            int iRent = objScore.SearchScoreTea(strUserNo, out objDataTable, out strErr);
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

        void BindDataGridViewStu()
        {
            string strErr = "";
            Manage.Score.Score objScore = new Manage.Score.Score(strConnection);
            DataTable objDataTable = new DataTable();
            int iRent = objScore.SearchScoreStu(strUserNo, out objDataTable, out strErr);
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

        private void menuAddScore_Click(object sender, EventArgs e)
        {
 
            AddScoreForm objAddScore = new AddScoreForm();
            objAddScore.ShowDialog();
            BindDataGridViewAdmin();
        }

        private void menuModifyScore_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中你要修改的行");
            }
            else
            {
                ModifyScoreForm objModifyScore = new ModifyScoreForm();
                objModifyScore.ShowDialog();
                BindDataGridViewAdmin();
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        //查询成绩
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strTeaNo = txtSearchScore.Text.Replace(@"\", @"\\");
            strTeaNo = strTeaNo.Replace("%", @"\%");
            strTeaNo = strTeaNo.Replace("_", @"\_");
            strTeaNo = strTeaNo.Replace("'", @"\''");
            strTeaNo = strTeaNo.Trim();

            string ClassNo = txtSearchScore.Text.Replace(@"\", @"\\");
            ClassNo = ClassNo.Replace("%", @"\%");
            ClassNo = ClassNo.Replace("_", @"\_");
            ClassNo = ClassNo.Replace("'", @"\''");
            ClassNo = ClassNo.Trim();

            string strStuNo = txtSearchScore.Text.Replace(@"\", @"\\");
            strStuNo = strStuNo.Replace("%", @"\%");
            strStuNo = strStuNo.Replace("_", @"\_");
            strStuNo = strStuNo.Replace("'", @"\''");
            strStuNo = strStuNo.Trim();

            string CourseNo = txtSearchScore.Text.Replace(@"\", @"\\");
            CourseNo = CourseNo.Replace("%", @"\%");
            CourseNo = CourseNo.Replace("_", @"\_");
            CourseNo = CourseNo.Replace("'", @"\''");
            CourseNo = CourseNo.Trim();

            string strErr = "";
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Score.Score objScore = new Manage.Score.Score(strConnection);
            if (txtSearchScore.Text == "")
            {
                MessageBox.Show("请输入你要查询的条件");
            }
            else if (iRight == 1)
            {
                if (lblSearchScore.Text == "请输入教师编号")
                {
                    int iRent = objScore.SearchScoreTeaByAdmin(strTeaNo,  out objDataTable, out strErr);
                    
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        show();
                    }
                }
                else if (lblSearchScore.Text == "请输入班级编号")
                {
                    int iRent = objScore.SearchScoreClass(ClassNo, out objDataTable, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        show();
                    }
                }
                else if (lblSearchScore.Text == "请输入学生编号")
                {
                    int iRent = objScore.SearchScoreStudent(strStuNo, out objDataTable, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        show();
                    }
                }
                else if (lblSearchScore.Text == "请输入课程编号")
                {
                    int iRent = objScore.SearchScoreCourse(CourseNo, out objDataTable, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                      //  dataGridView.DataSource = objDataTable;
                      //  dgvScore.DataSource = objDataTable;
                        show();
                    }
                }
            }
            else if (iRight == 2)
            {
                if (lblSearchScore.Text == "请输入课程编号")
                {
                    int iRent = objScore.SearchScoreCourseTea(CourseNo, strUserNo, out objDataTable, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        show();
                    }
                }
                else if (lblSearchScore.Text == "请输入班级编号")
                {
                    int iRent = objScore.SearchScoreClassTea(ClassNo, strUserNo, out objDataTable, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        show();
                    }
                }
                else if (lblSearchScore.Text == "请输入学生编号")
                {
                    int iRent = objScore.SearchScoreStuTea(strStuNo, strUserNo, out objDataTable, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        show();
                    }
                }

            }
            else
            {
                if (lblSearchScore.Text == "请输入课程编号")
                {
                    int iRent = objScore.SearchScoreCourseStu(CourseNo, strUserNo, out objDataTable, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {

                        show();
                    }

                }
                else if (lblSearchScore.Text == "请输入学生编号")
                {
                    int iRent = objScore.SearchScoreStuStu(strStuNo, strUserNo, out objDataTable, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        show();
                    }
                }
                if (lblSearchScore.Text == "请输入教师编号")
                {
                    int iRent = objScore.SearchScoreTeaStu(strTeaNo, strUserNo, out objDataTable, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        show();
                    }

                }
            }
        
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtSearchScore.Clear();
            this.txtStuName.Clear();
        }

        //private void menuDelScore_Click(object sender, EventArgs e)
        //{
        //    btnCancel.Visible = false;
        //    btnSearch.Visible = false;
        //    btnDel.Visible = true;
        //    btnReset.Visible = true;
        //    txtSearchScore.Visible = false;
        //    lblSearchScore.Visible = false;
        //    BindDataGridViewAdmin();
        //}

        //选中一行,删除成绩信息
        private void btnDel_Click(object sender, EventArgs e)
        {
            
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中你要删除的行");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("确定要删除所选行吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
                    Manage.Score.Score objScore = new Manage.Score.Score(strConnection);
                    string strErr = "";
                    for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                    {
                        string stuNo = dataGridView.SelectedRows[i].Cells["学号"].Value.ToString();
                        string courseNo = dataGridView.SelectedRows[i].Cells["课程编号"].Value.ToString();
                        stuNo = stuNo.Replace("'", "''");
                        stuNo = stuNo.Trim();

                        //int iCourseId = int.Parse(dataGridView.SelectedRows[i].Cells["课程编号"].Value.ToString());
                        int iRent = objScore.DelScore(stuNo, courseNo, out strErr);

                        if (iRent == 0)
                        {
                            MessageBox.Show(strErr);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("删除成功");
                        }
                    }
                    BindDataGridViewAdmin();
                }
            }        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void menuSearchByTea_Click(object sender, EventArgs e)//按教师查询成绩
        {

            btnCancel.Visible = true;
            btnSearch.Visible = true;
            txtSearchScore.Visible = true;
            lblSearchScore.Visible = true;
            menuAddScore.Visible = false;
          //  menuDelScore.Visible = false;
            txtStuName.Visible = false;
            lblStuName.Visible = false;
            menuModifyScore.Visible = false;
            lblSearchScore.Text = "请输入教师编号";
            txtSearchScore.Text = "";

            if (iRight == 1)
            {
                BindDataGridViewAdmin();
            }

            else if (iRight == 3)
            {
                BindDataGridViewStu();
            }
        }

        private void menuSearchByStu_Click(object sender, EventArgs e)//按学生查询成绩
        {
            
            btnCancel.Visible = true;
            btnSearch.Visible = true;
            txtSearchScore.Visible = true;
            lblSearchScore.Visible = true;
            lblSearchScore.Text = "请输入学生编号";
            menuAddScore.Visible = false;
          //  menuDelScore.Visible = false;
            menuModifyScore.Visible = false;
            btnReset.Visible = false;         
            lblStuName.Visible = false;
            txtStuName.Visible = false;
            txtSearchScore.Text = "";

            if (iRight == 1)
            {
                BindDataGridViewAdmin();

            }
            else if (iRight == 2)
            {
                BindDataGridViewTea();
            }
            else
            {
                BindDataGridViewStu();
            }
        }

        private void menuSearchByCla_Click(object sender, EventArgs e)//按班级查询成绩
        {
            btnCancel.Visible = true;
            btnSearch.Visible = true;
            txtSearchScore.Visible = true;
            lblSearchScore.Visible = true;
            lblSearchScore.Text = "请输入班级编号";
            menuAddScore.Visible = false;
          //  menuDelScore.Visible = false;
            menuModifyScore.Visible = false;
            txtStuName.Visible = false;
            lblStuName.Visible = false;
            txtSearchScore.Text = "";

            if (iRight == 1)
            {
                BindDataGridViewAdmin();

            }
            else if (iRight == 2)
            {
                BindDataGridViewTea();
            }
            else
            {
                BindDataGridViewStu();
            }
        }

        private void menuSearchByCou_Click(object sender, EventArgs e)//按课程查询成绩
        {

            btnCancel.Visible = true;
            btnSearch.Visible = true;
            txtSearchScore.Visible = true;
            lblSearchScore.Visible = true;
            lblSearchScore.Text = "请输入课程编号";
            menuAddScore.Visible = false;
          //  menuDelScore.Visible = false;
            menuModifyScore.Visible = false;
            btnReset.Visible = false;            
            lblStuName.Visible = false;
            txtStuName.Visible = false;
            txtSearchScore.Text = "";
        }

        private void menuSearchAll_Click(object sender, EventArgs e)//查询所有成绩
        {
            btnCancel.Visible = false;
            btnSearch.Visible = false;
            txtSearchScore.Visible = false;
            lblSearchScore.Visible = false;
            txtStuName.Visible = false;
            lblStuName.Visible = false;
            txtSearchScore.Text = "";

            if (iRight == 1)
            {
                BindDataGridViewAdmin();
                menuAddScore.Visible = true;
              //  menuDelScore.Visible = true;
                menuModifyScore.Visible = true;

            }
            else if (iRight == 2)
            {
                BindDataGridViewTea();
            }
            else
            {
                BindDataGridViewStu();
            }
        }


        //private void ScoreManagerForm_Load_1(object sender, EventArgs e)
        //{
        //    if (iRight != 1)
        //    {
        //        menuAddScore.Visible = false;
        //        menuDelScore.Visible = false;
        //        menuModifyScore.Visible = false;
        //        if (iRight == 2)
        //        {
        //            menuSearchByTea.Visible = false;
        //            menuSearchScore.Text = "查询所教学生成绩";
        //        }
        //        else
        //        {
        //            menuSearchByClass.Visible = false;
        //            menuSearchScore.Text = "查询本班学生成绩";
        //        }
        //    }
        //}

        private void show()
        {
            if (objDataTable.Rows.Count == 0)
            {
                MessageBox.Show("没有您要查询的记录");
            }
            else
            {
                dataGridView.DataSource=objDataTable;
             //   dgvScore.DataSource = objDataTable;
            }
        }






        private void ScoreManageForm_Load(object sender, EventArgs e)
        {
            if (iRight == 1)
            {
                BindDataGridViewAdmin();
            }
            else if (iRight == 2)
            {
                menuAddScore.Visible = false;
              //  menuDelScore.Visible = false;
                menuModifyScore.Visible = false;
                btnDel.Visible = false;               
                BindDataGridViewTea();
            }
            else
            {
                txtStuName.Visible = false;                
                BindDataGridViewStu();
                menuAddScore.Visible = false;
               // menuDelScore.Visible = false;
                menuModifyScore.Visible = false;
                btnDel.Visible = false;
               
            }          
        }




        public string StuName { get; set; }
    }
}