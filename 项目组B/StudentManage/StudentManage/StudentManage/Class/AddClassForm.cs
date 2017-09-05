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
                MessageBox.Show("�뽫��Ϣ��д������");
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
                        MessageBox.Show("��ӳɹ�");
                        this.Visible = false;
                    }
                }
                else if (i == 1 && j == 0)
                {
                    MessageBox.Show("��ǰ�༶�Ѿ����ڣ��½�ʧ��");
                }
                else if (i == 0 && j == 1)
                {
                    MessageBox.Show("��ǰ�༶�����Ѿ����ڣ��½�ʧ��");
                }
                else
                {
                    MessageBox.Show("�༶��źͰ༶���ƶ��Ѿ����ڣ��½�ʧ��");
                }                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}