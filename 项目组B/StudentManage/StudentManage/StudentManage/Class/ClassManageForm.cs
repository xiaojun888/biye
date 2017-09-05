using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace StudentManage.Class
{
    public partial class ClassManageForm : Form
    {
        public int iRights;
        public string strUsersNo;
        public ClassManageForm(int iRight, string strUserNo)
        {
            iRights = iRight;
            strUsersNo = strUserNo;
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            menuModifyClass_Click(sender, e);
        }

        private void ClassManageForm_Load(object sender, EventArgs e)
        {
            if (iRights == 1)
            {
                BindDataGridView();
            }
            else if (iRights == 2)
            {
                menuAddClass.Visible = false;
                menuModifyClass.Visible = false;
                menuDelClass.Visible = false;
                btnDel.Visible = false;
                btnModify.Visible = false;
                BindDataGridView1();
            }
            else
            {
                menuAddClass.Visible = false;
                menuModifyClass.Visible = false;
                menuDelClass.Visible = false;
                btnDel.Visible = false;
                btnModify.Visible = false;
                BindDataGridView1();
            }

        }
        void BindDataGridView1()
        {
            string strErr = "";
            DataTable objDataTable = new DataTable();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Class.Class objClass = new Manage.Class.Class(strConnection);
            int iRent = objClass.SearchClass2(strUsersNo, out objDataTable, out strErr);
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

        void BindDataGridView()
        {
            string strErr = "";
            DataTable objDataTable = new DataTable();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Class.Class objClass = new Manage.Class.Class(strConnection);
            int iRent = objClass.SearchClass(out objDataTable, out strErr);
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

        private void menuAddClass_Click(object sender, EventArgs e)
        {
            StudentManage.Class.AddClassForm AddClassForm = new AddClassForm();
            AddClassForm.ShowDialog();
            BindDataGridView();
        }

        private void menuModifyClass_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("����ѡ����Ҫ�޸ĵ�һ��");
            }
            else if (dataGridView.SelectedRows.Count == 1)
            {
                string classNo = dataGridView.SelectedRows[0].Cells["�༶���"].Value.ToString();
                StudentManage.Class.ModifyClassForm ModifyClassForm = new ModifyClassForm(classNo);
                ModifyClassForm.ShowDialog();
                BindDataGridView();
            }
            else
            {
                MessageBox.Show("һ��ֻ���޸�һ��");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strErr = "";
            DataTable objDataTable = new DataTable();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Class.Class objClass = new Manage.Class.Class(strConnection);
            string ClassNo = txtClassNo.Text.Replace(@"\", @"\\");
           

            ClassNo = ClassNo.Replace("%", @"\%");
            ClassNo = ClassNo.Replace("_", @"\_");
            ClassNo = ClassNo.Replace("'", @"\''");
            ClassNo = ClassNo.Trim();
            string ClassName = txtClassName.Text.Replace(@"\", @"\\");
            ClassName = ClassName.Replace("%", @"\%");
            ClassName = ClassName.Replace("_", @"\_");
            ClassName = ClassName.Replace("'", @"\''");
            ClassName = ClassName.Trim();
            if (iRights == 1)
            {
                int iRent = objClass.SearchClassByClassNoClassName(ClassNo, ClassName, out objDataTable, out strErr);
                if (iRent == 0)
                {
                    MessageBox.Show(strErr);
                }
                else
                {
                    if (objDataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("û����Ҫ��ѯ�ļ�¼");
                    }
                    else
                    {
                        dataGridView.DataSource = objDataTable;
                    }

                }
            }
            else
            {
                int iRent = objClass.SearchClassByClassNoClassNameTea(ClassNo, ClassName, strUsersNo, out objDataTable, out strErr);
                if (iRent == 0)
                {
                    MessageBox.Show(strErr);
                }
                else
                {
                    if (objDataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("û����Ҫ��ѯ�ļ�¼");
                    }
                    else
                    {
                        dataGridView.DataSource = objDataTable;
                    }

                }
            }

            txtClassName.Text = "";
            txtClassNo.Text = "";
        }

        private void menuSearchClass_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("����ѡ����Ҫɾ������");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("ɾ���༶ǰҪȷ���ð�û��ѧ��", "ȷ��ɾ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
                    Manage.Class.Class objClass = new Manage.Class.Class(strConnection);
                    string strErr = "";
                    for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                    {
                        string classNo = dataGridView.SelectedRows[i].Cells["�༶���"].Value.ToString();
                        classNo = classNo.Replace("'", "''");
                        classNo = classNo.Trim();
                        string className = dataGridView.SelectedRows[i].Cells["�༶����"].Value.ToString();
                        className = className.Replace("'", "''");
                        className = className.Trim();
                        int j = objClass.JudgeExistStu(classNo);
                        if (j == 0)
                        {
                            int iRent = objClass.DelClass(classNo, className, out strErr);
                            if (iRent == 0)
                            {
                                MessageBox.Show(strErr);
                                return;
                            }                           
                        }
                        else
                        {
                            MessageBox.Show("����ɾ���ð༶���ð༶����ѧ��");
                            BindDataGridView();
                            return;
                        }
                    }
                    BindDataGridView();
                }
            }
        }

        private void menuDelClass_Click(object sender, EventArgs e)
        {
            btnDel_Click(sender, e);
        }
    }
}
