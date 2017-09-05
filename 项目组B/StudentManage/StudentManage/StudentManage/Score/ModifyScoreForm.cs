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
        //�޸ĳɼ���Ϣ
        private void btnSave_Click(object sender, EventArgs e)
        {
            string strErr = "";
            Model.Student.Student objStudent1 = new Model.Student.Student();
            Model.Course.Course objCourse1 = new Model.Course.Course();
            objStudent1.StuId = int.Parse(txtStuNo.ToString());
            objCourse1.CourseId = int.Parse(txtCourseNo.ToString());
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Score.Score objSco = new Manage.Score.Score(strConnection);
            int i = objSco.Judge(objStudent1, objCourse1);     //����Ϊ0����ʾ�����ڸóɼ���¼�������޸ġ�����Ϊ1����ʾ���ڼ�¼�������޸ġ�
            if (i == 1)
            {

                if (DialogResult.Yes == MessageBox.Show("���Ҫ�޸ĸóɼ���", "ȷ���޸�", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
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
                        MessageBox.Show("�޸ĳɹ�");
                        //BindDataGridView();
                        this.Visible = false;
                    }

                }
            }
            else if (i == 0)
            {
                MessageBox.Show("��ǰҪ�޸ĵĳɼ������ڣ���ȷ�������޸�");
            }
        }

        private void ModifyScoreForm_Load(object sender, EventArgs e)
        {

        }
    }
}