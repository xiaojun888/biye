using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManage.Login
{
    public partial class AccountForm : Form
    {
        public int iRight;
        public string strUserNo;
        public AccountForm(int iRights, string UserNo)
        {

            InitializeComponent();
            iRight = iRights;
            strUserNo = UserNo;
        }


        private void AccountForm_Load(object sender, EventArgs e)
        {
            if (iRight != 1)
            {
                menuModifyPWD.Visible = true;
                menuSearchPersonal.Visible = true;
                menuSearchUser.Visible = false;
                menuSearchTeaAll.Visible = false;
                menuSearchStuAll.Visible = false;
                menuModify.Visible = false;
                groupBox1.Visible = false;
                btnSearch.Visible = false;
                BindDataGridViewPersonalNews();
                menuDelUser.Visible = false;

            }
            else
            {
                menuModifyPWD.Visible = false;
                menuSearchPersonal.Visible = false;
                dataGridView.Visible = true;
                BindDataGridView();
            }
        }

        void BindDataGridView()
        {
            string strErr = "";
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Login.Login objLogin = new Manage.Login.Login(strConnection);
            DataTable objDataTable = new DataTable();
            int iRent = objLogin.SearchUser(out objDataTable, out strErr);
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

        void BindDataGridViewTeaAll()
        {
            string strErr = "";
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Login.Login objLogin = new Manage.Login.Login(strConnection);
            DataTable objDataTable = new DataTable();
            int iRent = objLogin.SearchUserisTea(out objDataTable, out strErr);
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


        void BindDataGridViewStuAll()
        {
            string strErr = "";
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Login.Login objLogin = new Manage.Login.Login(strConnection);
            DataTable objDataTable = new DataTable();
            int iRent = objLogin.SearchUserisStu(out objDataTable, out strErr);
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

        void BindDataGridViewPersonalNews()
        {

            string strErr = "";
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Login.Login objLogin = new Manage.Login.Login(strConnection);
            DataTable objDataTable = new DataTable();
            int iRent = objLogin.SearchPersonalNews(iRight, strUserNo, out objDataTable, out strErr);
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

        //�������޸Ľ���
        private void menuModifyPWD_Click(object sender, EventArgs e)
        {
            StudentManage.Login.ModifyPWDForm ModifyPWDForm = new ModifyPWDForm(iRight, strUserNo);
            ModifyPWDForm.ShowDialog();
        }


        //��ѯ�û�
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strUserNo = txtUserNo.Text.Replace(@"\", @"\\");
            strUserNo = strUserNo.Replace("%", @"\%");
            strUserNo = strUserNo.Replace("_", @"\_");
            strUserNo = strUserNo.Replace("'", @"\''");
            strUserNo = strUserNo.Trim();

            string strUserName = txtUserName.Text.Replace(@"\", @"\\");
            strUserName = strUserName.Replace("%", @"\%");
            strUserName = strUserName.Replace("_", @"\_");
            strUserName = strUserName.Replace("'", @"\''");
            strUserName = strUserName.Trim();

            //�ַ�������
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            Manage.Login.Login objlogin = new Manage.Login.Login(strConnection);
            string strErr = "";
            //�����û��˺Ż����û���������ѯ
            if (strUserNo == "" && strUserName == "")
            {
                BindDataGridView();
            }
            else
            {
                DataTable objDataTable = new DataTable();

                int iRent = objlogin.SearchUserBy(strUserNo, strUserName, out objDataTable, out strErr);

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
                txtUserNo.Text = "";
                txtUserName.Text = "";

            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


        private void menuSearchUser_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void menuSearchTeaAll_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            BindDataGridViewTeaAll();

        }

        private void menuSearchStuAll_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            BindDataGridViewStuAll();
        }

        private void menuSearchPersonal_Click(object sender, EventArgs e)
        {
            dataGridView.Visible = true;
            BindDataGridViewPersonalNews();
        }

        //�޸��û���Ϣ
        private void menuModify_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("����ѡ��һ��");
            }
            else if (dataGridView.SelectedRows.Count == 1)
            {
                int iRights = int.Parse(dataGridView.SelectedRows[0].Cells["Ȩ��"].Value.ToString());
                string strUserNO = dataGridView.SelectedRows[0].Cells["�ʺ�"].Value.ToString();
                ModifyNewsForm objModifyUsers = new ModifyNewsForm(iRights, strUserNO);
                objModifyUsers.ShowDialog();
                BindDataGridView();
            }
            else
            {
                MessageBox.Show("һ��ֻ���޸�һ��");
            }
        }

        //ɾ���û�
        private void menuDelUser_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("����ѡ��Ҫɾ������");
            }
            else
            {
                string strErr = "";
                string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
                Manage.Login.Login objlogin = new Manage.Login.Login(strConnection);
                for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                {
                    int iRights = int.Parse(dataGridView.SelectedRows[i].Cells["Ȩ��"].Value.ToString());
                    string strUserNumble = dataGridView.SelectedRows[i].Cells["�ʺ�"].Value.ToString();
                    int iRent = objlogin.DelUser(iRights, strUserNumble, out strErr);
                    if (iRent == 0)
                    {
                        MessageBox.Show(strErr);
                        return;
                    }
                }
                BindDataGridView();

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            menuDelUser_Click(sender, e);
        }

        //����
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

    }
}