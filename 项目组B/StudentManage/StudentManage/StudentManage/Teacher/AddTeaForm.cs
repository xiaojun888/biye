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
                MessageBox.Show("�뽫��Ϣ��д������");
            }
            else
            {
                if (rabMan.Checked == true)
                {
                    objTeacher.Sex = "��";
                }
                else
                {
                    objTeacher.Sex = "Ů";
                }
                objTeacher.Age = int.Parse(nudAge.Value.ToString());
                objTeacher.Rank = cmbRank.SelectedItem.ToString();
                objTeacher.Degree = cmbDegree.SelectedItem.ToString();
                objTeacher.TeaAddress = txtAddress.Text.Replace("'", "''");
                objTeacher.TeaTel = txtTel.Text.Replace("'", "''");
                objTeacher.Remark = txtRemark.Text.Replace("'", "''");
                int iTeaNo = objTea.JudgeTeaNo(objTeacher.TeaNo);                                   //�жϽ�ʦ��ż��Ƿ��ظ�
                int iR = objTea.JudgeTeaNoLikeStuNo(objTeacher.TeaNo);                             //�жϽ�ʦ�����ѧ������Ƿ��ظ�
                if (iTeaNo == 0)
                {
                    MessageBox.Show("�˱�ŵĽ�ʦ�Ѿ����ڣ����ʧ��");
                }
                else if (iR == 0)
                {
                    MessageBox.Show("����һ���˱�ŵ�ѧ������ʦ��Ų��ܺ�ѧ�������ͬ");
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
                        MessageBox.Show("��ӳɹ�");
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