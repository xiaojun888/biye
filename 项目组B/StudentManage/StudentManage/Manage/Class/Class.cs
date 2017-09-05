using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Manage.Class
{
    public class Class
    {
        SqlConnection sqlCon;
        public Class(string strConectionString)
        {
            sqlCon = new SqlConnection(strConectionString);
        }
       
        public int AddClass(Model.Class.Class objClass, out string strErr)//���Ӱ༶��Ϣ
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();

            string strSql = "insert into Class(classno,classname,remark,type)";
            strSql += "values('" + objClass.ClassNo + "','" + objClass.ClassName +"','" + objClass.Remark + "',1)";

            sqlCom.CommandText = strSql;
            sqlCom.Connection = sqlCon;
            try
            {
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
                iRent = 1;
            }
            catch (Exception exErr)
            {
                strErr = exErr.ToString();
                iRent = 0;
            }
            finally
            {
                sqlCon.Close();
                sqlCom.Dispose();
            }
            return iRent;
        }

        public int DelClass(string classNo,string className, out string strErr)//ɾ���༶��Ϣ��ͬʱ��ɾ��class_course���class_teacher�����������Ϣ��
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strSql = " update class set type = 0 where classno = '" + classNo + "' ";
            strSql += "update Class_course set type = 0 where classid in (select classid from class where classNo ='"+ classNo +"') ";
            strSql += "update Class_teacher set type = 0 where classid in (select classid from class where classNo ='"+ classNo +"') ";
            sqlCom.CommandText = strSql;
            sqlCom.Connection = sqlCon;
            try
            {
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
                iRent = 1;
            }
            catch (Exception exErr)
            {
                strErr = exErr.ToString();
                iRent = 0;
            }
            finally
            {
                sqlCon.Close();
                sqlCom.Dispose();
            }
            return iRent;
        }
        public int JudgeExistStu(string classNo)//�жϸð༶���Ƿ���ѧ������ѧ��ʱ������ɾ���༶
        {
            string strErr = "";
            DataSet ds = new DataSet();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
             string strSql = " select stuId from student where classid in ( select classid from class where  classno = '" + classNo + "')and type =1 ";
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = strConnection;
            sqlCon.Open();
            SqlCommand sqlCom = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(strSql, sqlCon);
            try
            {
                da.Fill(ds);
            }
            catch (Exception exce)
            {
                strErr = exce.ToString();
            }
            finally
            {
                sqlCon.Close();
            }

            if (ds.Tables[0].Rows.Count == 0)
            {
                return 0;
            }

            else
            {
                return 1;
            }
        } 
   
        public int SearchClass(out DataTable objDataTable, out string strErr) //��ѯ���а༶��¼(����ʾclassId)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "select classno �༶���,classname �༶����,remark ��ע from class where type =1";
            sqlCom.Connection = sqlCon;
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlDa.SelectCommand = sqlCom;

            try
            {
                sqlDa.Fill(objDataTable);
                iReturn = 1;
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
                iReturn = 0;
            }
            finally
            {
                sqlDa.Dispose();
                sqlCom.Dispose();
            }
            return iReturn;
        }

        public int SearchClass2(string strUsersNo,out DataTable objDataTable, out string strErr) //��ѯ���а༶��¼(����ʾclassId)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string userNo = strUsersNo.Replace("'","''");
            sqlCom.CommandText = "select distinct classNo �༶���,className �༶����,teaNo ��ʦ���,teaName ��ʦ���� from teacher a,class b,class_teacher c where b.type =1 and a.type =1 and c.type =1 and b.classId =c.classid and a.teaid = c.teaid and a.teaNo ='"+userNo+"'";
            sqlCom.Connection = sqlCon;
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlDa.SelectCommand = sqlCom;

            try
            {
                sqlDa.Fill(objDataTable);
                iReturn = 1;
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
                iReturn = 0;
            }
            finally
            {
                sqlDa.Dispose();
                sqlCom.Dispose();
            }
            return iReturn;
        }
        public int SearchClass1(out DataTable objDataTable, out string strErr) //��ѯ���а༶��¼
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "select classId �༶Id, classno �༶���,classname �༶����,remark ��ע from class where type =1";
            sqlCom.Connection = sqlCon;
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlDa.SelectCommand = sqlCom;

            try
            {
                sqlDa.Fill(objDataTable);
                iReturn = 1;
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
                iReturn = 0;
            }
            finally
            {
                sqlDa.Dispose();
                sqlCom.Dispose();
            }
            return iReturn;
        }

        public int SearchClassByClassNoClassName(string strClassNo, string strClassName, out DataTable objDataTable, out string strErr) //��ѯ�༶��¼�����༶���ƺͱ�ţ�
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "select classno �༶���,classname �༶����,remark ��ע from class where classNo like'%" + strClassNo + "%' escape '\\'and className like'%" + strClassName + "%' escape '\\' and type =1";
            sqlCom.Connection = sqlCon;
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlDa.SelectCommand = sqlCom;

            try
            {
                sqlDa.Fill(objDataTable);
                iReturn = 1;
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
                iReturn = 0;
            }
            finally
            {
                sqlDa.Dispose();
                sqlCom.Dispose();
            }
            return iReturn;
        }

        public int SearchClassByClassNoClassNameTea(string strClassNo, string strClassName,string strTeaNo, out DataTable objDataTable, out string strErr) //��ѯ�༶��¼�����༶���ƺͱ�ţ�
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "select classno �༶���,classname �༶����,remark ��ע from class where classNo like'%" + strClassNo + "%' escape '\\'and className like'%" + strClassName + "%' escape '\\' and type =1 and classid in(select classid from class_Teacher,teacher where class_teacher.teaid = teacher.teaid and class_teacher.type =1 and teaNo ='"+ strTeaNo +"')";
            sqlCom.Connection = sqlCon;
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlDa.SelectCommand = sqlCom;

            try
            {
                sqlDa.Fill(objDataTable);
                iReturn = 1;
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
                iReturn = 0;
            }
            finally
            {
                sqlDa.Dispose();
                sqlCom.Dispose();
            }
            return iReturn;
        }


        public int ModifyClass(string classNo,Model.Class.Class objClass, out string strErr)//�޸İ༶��Ϣ
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "update class ";
            strSql += "set classname='" + objClass.ClassName + "',remark='" + objClass.Remark + "', classNo = '"+objClass.ClassNo+"'where classId in (select classId from class where classNo ='"+ classNo.Replace ("'","''") +"')";
            sqlCom.CommandText = strSql;
            sqlCom.Connection = sqlCon;
            try
            {
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
                iRent = 1;
            }
            catch (Exception exErr)
            {
                strErr = exErr.ToString();
                iRent = 0;
            }
            finally
            {
                sqlCon.Close();
                sqlCom.Dispose();
            }
            return iRent;
        }

        public int JudgeClassNo(Model.Class.Class objClassNo)//ͨ����ѯ����İ༶����Ƿ�������ж��ܲ�����ӵ�ǰ�༶�����ز�ѯ�����0���0
        {

            string strErr = "";
            DataSet ds = new DataSet();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            string strSql = "select classId from class where classNo = '" + objClassNo.ClassNo + "' and type =1 ";
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = strConnection;
            sqlCon.Open();
            SqlCommand sqlCom = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(strSql, sqlCon);
            try
            {
                da.Fill(ds);
            }
            catch (Exception exce)
            {
                strErr = exce.ToString();
            }
            finally
            {
                sqlCon.Close();
            }

            if (ds.Tables[0].Rows.Count == 0)
            {
                return 0;
            }

            else
            {
                return 1;
            }

        }

        public int JudgeClassName(Model.Class.Class objClassName)//ͨ����ѯ����İ༶�����Ƿ�������ж��ܲ�����ӵ�ǰ�༶�����ز�ѯ�����0���0
        {

            string strErr = "";
            DataSet ds = new DataSet();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            string strSql = "select classId from class where className = '" + objClassName.ClassName + "' and type =1 ";
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = strConnection;
            sqlCon.Open();
            SqlCommand sqlCom = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(strSql, sqlCon);
            try
            {
                da.Fill(ds);
            }
            catch (Exception exce)
            {
                strErr = exce.ToString();
            }
            finally
            {
                sqlCon.Close();
            }

            if (ds.Tables[0].Rows.Count == 0)
            {
                return 0;
            }

            else
            {
                return 1;
            }

        }

        //ѧ���ͳɼ��л��õ�  
        public int SearchClass3(out DataTable objDataTable, out string strErr)
        {
            objDataTable = new DataTable();
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "select ClassId,ClassName from Class where Type=1";
            sqlCom.Connection = sqlCon;
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCom);

            try
            {
                sqlDa.Fill(objDataTable);
                iReturn = 1;
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
                iReturn = 0;
            }
            finally
            {
                sqlDa.Dispose();
                sqlCom.Dispose();
            }
            return iReturn;
        }
    }
}
