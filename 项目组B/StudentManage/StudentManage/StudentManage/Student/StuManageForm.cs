using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManage.Student
{
    public partial class StuManageForm : Form
    {
        public int iRight;
        public string strUserNo;
        public StuManageForm(int iRights,string UserNo)      
        {
            InitializeComponent();
            iRight = iRights;
            strUserNo = UserNo; 
        }

      
        private void StuManageForm_Load(object sender, EventArgs e)
        {
            //BindDataGridView();
            if (iRight == 1)
            {
                BindDataGridView();
            }
            else if (iRight == 2)
            {
                menuAddStu.Visible = false;
                menuDelStu.Visible = false;
                menuModifyStu.Visible = false;
                btnDel.Visible = false;
                btnModify.Visible = false;
                BindDataGridView();
            }
            else
            {
                txtClassName.Visible = false;
                lblClassName.Visible = false;
                BindDataGridView();
                menuAddStu.Visible = false;
                menuDelStu.Visible = false;
                menuModifyStu.Visible = false;
                btnDel.Visible = false;
                btnModify.Visible = false;
            }

        }

        void BindDataGridView()
        {
            string strErr = "";
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Student.Student objStudent = new Manage.Student.Student(strConnection);
            DataTable objDataTable = new DataTable();
            int iRent = objStudent.SearchStuAll(iRight, strUserNo, out objDataTable, out strErr);
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

        private void menuAddStu_Click(object sender, EventArgs e)
        {
            StudentManage.Student.AddStuForm AddStuForm = new AddStuForm();
            AddStuForm.ShowDialog();
            BindDataGridView();
        }

        private void menuModifyStu_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("����ѡ��һ��");
            }
            else if (dataGridView.SelectedRows.Count == 1)
            {
                //int iStuId = int.Parse(dataGridView.SelectedRows[0].Cells["ѧ��ID"].Value.ToString());
                string strStuno = dataGridView.SelectedRows[0].Cells["ѧ�����"].Value.ToString();
                //ModifyStuForm objMdfStu = new ModifyStuForm(iStuId);
                ModifyStuForm objMdfStu = new ModifyStuForm(strStuno);
                objMdfStu.ShowDialog();
                BindDataGridView();
            }
            else
            {
                MessageBox.Show("һ��ֻ���޸�һ��");
            }
        }

        private void menuSearchStu_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void menuDelStu_Click(object sender, EventArgs e)
        {
            btnDel_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strStuNo = txtStuNo.Text.Replace("'","''");
            strStuNo = strStuNo.Replace(@"\", @"\\");
            strStuNo = strStuNo.Replace("%", @"\%");
            strStuNo = strStuNo.Replace("_", @"\_");

            strStuNo = strStuNo.Trim();
            string strStuName = txtStuName.Text.Replace("'", "''");
            strStuName = strStuName.Replace(@"\",  @"\\");
            strStuName = strStuName.Replace("%", @"\%");
            strStuName = strStuName.Replace("_", @"\_");
           
            strStuName = strStuName.Trim();
            string strClassName = txtClassName.Text.Replace("'", "''");
            strClassName = strClassName.Replace(@"\", @"\\");
            strClassName = strClassName.Replace("%", @"\%");
            strClassName = strClassName.Replace("_", @"\_");

            strClassName = strClassName.Trim();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Student.Student objStudent = new Manage.Student.Student(strConnection);
            string strErr = "";
            if (strStuNo == "" && strStuName == "" && strClassName == "")
            {
                BindDataGridView();
            }
            else
            {
                DataTable objDataTable = new DataTable();

                int iRent = objStudent.SearchStuBy(iRight, strUserNo, strStuNo, strStuName, strClassName, out objDataTable, out strErr);

                if (iRent == 0)
                {
                    MessageBox.Show(strErr);
                }
                else
                {
                    if (objDataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("û����Ҫ��ѯ�ļ�¼");
                        dataGridView.DataSource = objDataTable;
                    }
                    else
                    {
                        dataGridView.DataSource = objDataTable;
                    }

                }
                txtStuNo.Text = "";
                txtStuName.Text = "";
                txtClassName.Text = "";
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            menuModifyStu_Click(sender, e);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("����ѡ��һ��");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("ȷ��Ҫɾ����ͬʱ��ɾ����ѧ����ϵͳ�˺ż��ɼ���Ϣ\n ", "ȷ��ɾ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
                    Manage.Student.Student objStudent = new Manage.Student.Student(strConnection);
                    string strErr = "";
                    for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                    {
                        //int iStuId = int.Parse(dataGridView.SelectedRows[i].Cells["ѧ��ID"].Value.ToString());
                        string strStuNo = dataGridView.SelectedRows[i].Cells["ѧ�����"].Value.ToString();
                        int iRent = objStudent.DelStu( strStuNo, out strErr);
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

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


      
    }
}