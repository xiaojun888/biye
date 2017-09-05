using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StudentManage.Student
{
    public partial class AddStuForm : Form
    {
        public AddStuForm()
        {
            InitializeComponent();
        }

        private void AddStuForm_Load(object sender, EventArgs e)
        {
            BindClassId();
        }

        void BindClassId()
        {
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Class.Class objClass = new Manage.Class.Class(strConnection);
            string strErr = "";
            DataTable objDataTable = new DataTable();
            int iRent = objClass.SearchClass3(out objDataTable, out strErr);
            if (iRent == 0)
            {
                MessageBox.Show(strErr);
                return;
            }
            else
            {
                cmbClassId.DataSource = objDataTable;
                cmbClassId.DisplayMember = "ClassName";
                cmbClassId.ValueMember = "ClassId";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strErr = "";
            Model.Student.Student objStudent = new Model.Student.Student();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Student.Student objStu = new Manage.Student.Student(strConnection);
            int Ar = objStu.JudgeClassExist();
            if (Ar == 0)
            {
                MessageBox.Show("�����ڰ༶,���������ѧ��");
            }
            else
            {
                objStudent.StuNo = txtStuNo.Text.Replace("'", "''");
                objStudent.StuNo = objStudent.StuNo.Trim();
                objStudent.StuName = txtStuName.Text.Replace("'", "''");
                objStudent.StuName = objStudent.StuName.Trim();
                if (objStudent.StuNo == "" || objStudent.StuName == "")
                {
                    MessageBox.Show("�뽫��Ϣ��д������");
                }
                else
                {
                    if (rabWoman.Checked == true)
                    {
                        objStudent.Sex = "Ů";
                    }
                    else
                    {
                        objStudent.Sex = "��";
                    }
                    objStudent.BirthDate = dtpBirthDate.Value;
                    objStudent.EntranceTime = dtpEntranceTime.Value;
                    //objStudent.StuTel = txtStuTel.Text.ToString();
                    //objStudent.StuTel = txtStuTel.Text.Replace("'", "''");
                    if (this.txtStuTel.Text != "")
                    {
                        string patten = @"(13\d{9}(;13\d{9})*)|(15\d{9}(;15\d{9})*)|(\(\d{3,4}\)|\d{3,4}-)?\d{7,8}(;(\(\d{3,4}\)|\d{3,4}-)?\d{7,8})*";
                        Regex r = new Regex(patten);
                        Match m = r.Match(txtStuTel.Text);
                        if (!m.Success)
                        {
                            MessageBox.Show("��������ȷ�ĵ绰����");
                            this.txtStuTel.Text = "";
                            this.txtStuTel.Focus();
                            return;
                        }
                        else
                        {
                            objStudent.StuTel = txtStuTel.Text.ToString();
                        }
                    }

                    objStudent.StuAddress = txtAddress.Text.Replace("'", "''");
                    objStudent.Remark = txtRemark.Text.Replace("'", "''");

                    objStudent.ClassId = int.Parse(cmbClassId.SelectedValue.ToString());
                    //int Ar= objStu. JudgeClassExist();

                    int iExist = objStu.JudgeStuNo(objStudent.StuNo);
                    int R = objStu.JudgeStuNoLikeTeaNo(objStudent.StuNo);
                    if (iExist == 1)
                    {
                        MessageBox.Show("�˱�ŵ�ѧ���Ѿ����ڣ�������Ϊ��ѧ�����");
                    }
                    else if (R == 1)
                    {
                        MessageBox.Show("����һ���˱�ŵĽ�ʦ��ѧ����Ų��ܺͽ�ʦ�����ͬ");
                    }
                    else
                    {
                        int iRent = objStu.AddStu(objStudent, out strErr);
                        if (iRent == 0)
                        {
                            MessageBox.Show(strErr);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("���ѧ����Ϣ�ɹ�,ͬʱϵͳΪ��ѧ�������˺ųɹ�");
                            this.Visible = false;
                        }
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtStuNo.Clear();
            this.txtStuName.Clear();
            this.rabMan.Checked = true;
            this.txtStuTel.Clear();
            this.txtRemark.Clear();
            this.txtAddress.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

       

        
    }
}