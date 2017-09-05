using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;





namespace StudentManage
{
    //private class List<Image> lst= new List<Image>();
    //List<Image> lst = new List<Image>();  
    // private int ImageIndex = 0;  
    // private Timer timer2 = new Timer();
    public partial class MainForm : Form
    {

        
        public int iRight;
        public string strUserNo;
        public string strPassWord;
        public MainForm(string userName, string passWord, int right)
        {
            InitializeComponent();
            iRight = right;
            strUserNo = userName;
            strPassWord = passWord;
        }
        
        //int i = 0;
        //退出当前系统
        private void menuExit_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("你确定你要退出本系统吗!");
            Application.Exit();

        }

        //当前用户以什么权限登录
        private void MainForm_Load(object sender, EventArgs e)
        {
            label2.Text = "计算机名:" + Environment.MachineName;
            label4.Text = "当前画质:" + SystemInformation.VirtualScreen.Width + "*" + SystemInformation.VirtualScreen.Height;
            lblUserNo.Text = strUserNo;
            if (iRight == 1)
            {
                lblUserMember.Text = "管理员";
            }
            else if (iRight == 2)
            {
                lblUserMember.Text = "教师";
            }
            else
            {
                lblUserMember.Text = "学生";
                menuClass.Enabled = false;
                pictureBox3.Enabled = false;
            }
        }

        private void menuClass_Click(object sender, EventArgs e)
        {
            Class.ClassManageForm objClass = new StudentManage.Class.ClassManageForm(iRight, strUserNo);
            objClass.ShowDialog();
        }

        private void menuTeacher_Click(object sender, EventArgs e)
        {
            Teacher.TeaManageForm objTea = new StudentManage.Teacher.TeaManageForm(iRight, strUserNo);
            objTea.ShowDialog();
        }

        private void menuStu_Click(object sender, EventArgs e)
        {
            Student.StuManageForm objStu = new StudentManage.Student.StuManageForm(iRight, strUserNo);
            objStu.ShowDialog();
        }

        private void menuScore_Click(object sender, EventArgs e)
        {
            Score.ScoreManageForm objScore = new StudentManage.Score.ScoreManageForm(iRight, strUserNo);
            objScore.ShowDialog();
        }

        private void menuCourse_Click(object sender, EventArgs e)
        {
            Course.CourseManageForm objCourse = new StudentManage.Course.CourseManageForm(iRight, strUserNo);
            objCourse.ShowDialog();
        }

        //注销用户
        private void menuFallBack_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Login.LoginInterfaceForm objLogin = new StudentManage.Login.LoginInterfaceForm();
            objLogin.ShowDialog();

        }

        private void menuAccount_Click(object sender, EventArgs e)
        {
            Login.AccountForm AccountForm = new StudentManage.Login.AccountForm(iRight, strUserNo);
            AccountForm.ShowDialog();
        }

        //获取当前时间与日期
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.Year.ToString() + "年" + DateTime.Now.Month.ToString() + "月" + DateTime.Now.Day.ToString() + "日\n";
            lblTime.Text += DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Score.ScoreManageForm ScoreManageForm = new Score.ScoreManageForm(iRight, strUserNo);
            ScoreManageForm.ShowDialog();
        }

        private void lblUserMember_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            /*int i = 0;
            i++;
            string filePath = Application.StartupPath + "\\JPG\\" + ToString() + ".jpg";
            this.pictureBox7.Image = Image.FromFile(filePath);
            if (i == 5)
            {
                i = 0;
            }
            
            
    }*/



        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

    }
}