using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManage.Teacher
{
    public partial class TeaManageForm : Form
    {
        int iRight;
        string strUserNo;
        public TeaManageForm(int right, string userNo)
        {
            iRight = right;
            strUserNo = userNo;
            InitializeComponent();
        }

        private void menuModifyTea_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.SelectedRows.Count;
            if (i == 0)
            {
                MessageBox.Show("请先选中一行");
            }
            else if (i == 1)
            {
                if (btnModify.Text == "修　改")
                {
                    string strTeaNo = dataGridView1.SelectedRows[0].Cells["教师编号"].Value.ToString();
                    StudentManage.Teacher.ModifyTeaForm ModifyTeaForm = new ModifyTeaForm(strTeaNo);
                    ModifyTeaForm.ShowDialog();
                    BindDataGridView();
                }
                else
                {
                    this.Visible = false;
                    string strTeaNo = dataGridView1.SelectedRows[0].Cells["教师编号"].Value.ToString();
                    StudentManage.Teacher.TeaEduManageForm TeaEduManageForm = (TeaEduManageForm)this.Owner;
                    TeaEduManageForm.txtTeaNo.Text = strTeaNo;
                    this.Close();
                    //TeaEduManageForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("一次只能选一行");
            }
        }

        private void TeaManageForm_Load(object sender, EventArgs e)
        {
            BindDataGridView();
            if (iRight != 1)
            {
                menuAddTea.Visible = false;
                menuDelTea.Visible = false;
                menuModifyTea.Visible = false;
                menuTeaEdu.Visible = false;
                btnDel.Visible = false;
                btnModify.Visible = false;
            }
            if (iRight == 3)
            {
                BindDataGridView2();
            }
        }
        void BindDataGridView()
        {
            string strErr = "";
            DataTable objDataTable = new DataTable();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Teacher.Teacher objTea = new Manage.Teacher.Teacher(strConnection);
            int iRent = objTea.SearchTea(out objDataTable, out strErr);
            if (iRent == 0)
            {
                MessageBox.Show(strErr);
                return;
            }
            else
            {
                dataGridView1.DataSource = objDataTable;
            }
        }
        void BindDataGridView2()
        {
            string strErr = "";
            DataTable objDataTable = new DataTable();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Teacher.Teacher objTea = new Manage.Teacher.Teacher(strConnection);
            int iRent = objTea.StuSearchAllTea(strUserNo, out objDataTable, out strErr);
            if (iRent == 0)
            {
                MessageBox.Show(strErr);
                return;
            }
            else
            {
                dataGridView1.DataSource = objDataTable;
            }
        }

        private void menuSearchTea_Click(object sender, EventArgs e)
        {
            string strErr = "";
            DataTable objDataTable = new DataTable();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Teacher.Teacher objTea = new Manage.Teacher.Teacher(strConnection);
            string strTeaNo = txtTeaNo.Text;
            strTeaNo = strTeaNo.Replace("%", @"\%");
            strTeaNo = strTeaNo.Replace("_", @"\_");
            strTeaNo = strTeaNo.Replace("'", @"\''");
            strTeaNo = strTeaNo.Trim();
            string strTeaName = txtTeaName.Text;
            strTeaName = strTeaName.Replace("%", @"\%");
            strTeaName = strTeaName.Replace("_", @"\_");
            strTeaName = strTeaName.Replace("'", @"\''");
            strTeaName = strTeaName.Trim();

            if (iRight != 3)
            {
                int iRent = objTea.SearchTea(strTeaNo, strTeaName, out objDataTable, out strErr);
                if (iRent == 0)
                {
                    MessageBox.Show(strErr);
                    return;
                }
                else
                {
                    if (objDataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("没有符合你要查询的记录");
                    }
                    else
                    {
                        dataGridView1.DataSource = objDataTable;
                    }
                    txtTeaName.Text = "";
                    txtTeaNo.Text = "";
                }
            }
            else
            {
                int iRent = objTea.StuSearchOneTeaNo(strTeaNo, strTeaName, strUserNo, out objDataTable, out strErr);
                if (iRent == 0)
                {
                    MessageBox.Show(strErr);
                    return;
                }
                else
                {
                    if (objDataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("没有符合你要查询的记录");
                    }
                    else
                    {
                        dataGridView1.DataSource = objDataTable;
                    }
                    txtTeaName.Text = "";
                    txtTeaNo.Text = "";
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.SelectedRows.Count;
            if (i == 0)
            {
                MessageBox.Show("请先选中你要删除的一行");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("真的要删除吗？", "确认退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    for (int j = 0; j < dataGridView1.SelectedRows.Count; j++)
                    {
                        string strTeaNo = dataGridView1.SelectedRows[j].Cells["教师编号"].Value.ToString();
                        string strErr = "";
                        string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
                        Manage.Teacher.Teacher objTea = new Manage.Teacher.Teacher(strConnection);
                        int iRent = objTea.DelTea(strTeaNo, out strErr);
                        if (iRent == 0)
                        {
                            MessageBox.Show(strErr);
                            return;
                        }
                    }
                    MessageBox.Show("删除成功");
                }
                BindDataGridView();
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            //if (menuTeaEdu.Visible == true)
            //{
            this.Visible = false;
            //}
            //else
            //{
            //    string strTeaNo = "";
            //    this.Visible = false;
            //    StudentManage.Teacher.TeaEduManageForm TeaEduManageForm = new TeaEduManageForm();
            //    TeaEduManageForm.ShowDialog();
            //}
        }

        private void menuAddTea_Click(object sender, EventArgs e)
        {
            StudentManage.Teacher.AddTeaForm AddTeaForm = new AddTeaForm();
            AddTeaForm.ShowDialog();
            BindDataGridView();
        }

        private void menuTeaEdu_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            string strTeaNo = "";
            StudentManage.Teacher.TeaEduManageForm TeaEduManageForm = new TeaEduManageForm(strTeaNo);
            TeaEduManageForm.ShowDialog();
        }

    }
}