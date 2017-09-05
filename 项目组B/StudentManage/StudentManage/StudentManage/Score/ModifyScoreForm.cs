using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManage.Score
{
    public partial class ModifyScoreForm : Form
    {
       
        public ModifyScoreForm()
        {
            InitializeComponent();
         
        }
        //修改成绩信息
        private void btnSave_Click(object sender, EventArgs e)
        {
            string strErr = "";
            Model.Student.Student objStudent1 = new Model.Student.Student();
            Model.Course.Course objCourse1 = new Model.Course.Course();
            objStudent1.StuId = int.Parse(txtStuNo.ToString());
            objCourse1.CourseId = int.Parse(txtCourseNo.ToString());
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Score.Score objSco = new Manage.Score.Score(strConnection);
            int i = objSco.Judge(objStudent1, objCourse1);     //返回为0，表示不存在该成绩记录，不能修改。返回为1，表示存在记录，可以修改。
            if (i == 1)
            {

                if (DialogResult.Yes == MessageBox.Show("真的要修改该成绩吗？", "确认修改", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string strEr = "";
                    Model.Score.Score objScore = new Model.Score.Score();
                    Model.Student.Student objStudent = new Model.Student.Student();
                    Model.Course.Course objCourse = new Model.Course.Course();
                    objScore.CourseId = int.Parse(txtCourseNo.ToString());
                    objScore.StuId = int.Parse(txtStuNo.ToString());
                    objScore.score = float.Parse(nudScore.Value.ToString());
                    int iRent = objSco.ModifyScore(objScore, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strEr);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("修改成功");
                        //BindDataGridView();
                        this.Visible = false;
                    }

                }
            }
            else if (i == 0)
            {
                MessageBox.Show("当前要修改的成绩不存在，请确定后再修改");
            }
        }

        private void ModifyScoreForm_Load(object sender, EventArgs e)
        {

        }
    }
}