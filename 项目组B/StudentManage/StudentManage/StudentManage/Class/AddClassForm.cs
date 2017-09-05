using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManage.Class
{
    public partial class AddClassForm : Form
    {
        public AddClassForm()
        {
            InitializeComponent();
        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strErr = "";
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Model.Class.Class objClass = new Model.Class.Class();
            Manage.Class.Class objclass = new Manage.Class.Class(strConnection);
            objClass.ClassNo = txtClassNo.Text.Replace("'", "''");
            objClass.ClassNo = objClass.ClassNo.Trim();
            objClass.ClassName = txtClassName.Text.Replace("'", "''");
            objClass.ClassName = objClass.ClassName.Trim();
            objClass.Remark = txtRemark.Text.Replace("'", "''");
            objClass.Remark = objClass.Remark.Trim();
            if (objClass.ClassName == "" || objClass.ClassNo == "")
            {
                MessageBox.Show("请将信息填写完整！");
            }
            else
            {
                int i = objclass.JudgeClassNo(objClass);
                int j = objclass.JudgeClassName(objClass);
                if (i == 0 && j == 0)
                {
                    int iRent = objclass.AddClass(objClass, out strErr);

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
                else if (i == 1 && j == 0)
                {
                    MessageBox.Show("当前班级已经存在，新建失败");
                }
                else if (i == 0 && j == 1)
                {
                    MessageBox.Show("当前班级名称已经存在，新建失败");
                }
                else
                {
                    MessageBox.Show("班级编号和班级名称都已经存在，新建失败");
                }                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}