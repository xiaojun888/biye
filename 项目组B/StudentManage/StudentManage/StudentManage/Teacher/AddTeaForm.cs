using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManage.Teacher
{
    public partial class AddTeaForm : Form
    {
        public AddTeaForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strErr = "";
            Model.Teacher.Teacher objTeacher = new Model.Teacher.Teacher();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Teacher.Teacher objTea = new Manage.Teacher.Teacher(strConnection);
            objTeacher.TeaNo = txtTeaNo.Text.Replace("'", "''");
            objTeacher.TeaNo = objTeacher.TeaNo.Trim();
            objTeacher.TeaName = txtTeaName.Text.Replace("'", "''");
            objTeacher.TeaName = objTeacher.TeaName.Trim();
            if (objTeacher.TeaNo == "" || objTeacher.TeaName == "")
            {
                MessageBox.Show("请将信息填写完整！");
            }
            else
            {
                if (rabMan.Checked == true)
                {
                    objTeacher.Sex = "男";
                }
                else
                {
                    objTeacher.Sex = "女";
                }
                objTeacher.Age = int.Parse(nudAge.Value.ToString());
                objTeacher.Rank = cmbRank.SelectedItem.ToString();
                objTeacher.Degree = cmbDegree.SelectedItem.ToString();
                objTeacher.TeaAddress = txtAddress.Text.Replace("'", "''");
                objTeacher.TeaTel = txtTel.Text.Replace("'", "''");
                objTeacher.Remark = txtRemark.Text.Replace("'", "''");
                int iTeaNo = objTea.JudgeTeaNo(objTeacher.TeaNo);                                   //判断教师编号间是否重复
                int iR = objTea.JudgeTeaNoLikeStuNo(objTeacher.TeaNo);                             //判断教师编号与学生编号是否重复
                if (iTeaNo == 0)
                {
                    MessageBox.Show("此编号的教师已经存在，添加失败");
                }
                else if (iR == 0)
                {
                    MessageBox.Show("存在一个此编号的学生，教师编号不能和学生编号相同");
                }
                else
                {
                    int iRent = objTea.AddTea(objTeacher, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("添加成功");
                        this.Visible = false;
                    }
                }
            }

        }

        private void AddTeaForm_Load(object sender, EventArgs e)
        {
            cmbDegree.SelectedIndex = 0;
            cmbRank.SelectedIndex = 0;
        }
    }
}