using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Manage.Teacher
{
    public class Teacher
    {
        SqlConnection sqlCon;
        public Teacher(string strConectionString)
        {
            sqlCon = new SqlConnection(strConectionString);
        }
        //public int AddTea(Model.Teacher.Teacher objTea, out string strErr)Ϊ��ӵķ��� 
       //���ӽ�ʦ��Ϣ,int iRentΪ1�����Ϣ�ɹ�,ͬʱ����û��ɹ�,Ϊ0�򷵻ش�����ʾ,�������󸳸�strErr
        public int AddTea(Model.Teacher.Teacher objTea, out string strErr)                                                      //���ӽ�ʦ��Ϣͬʱ�����˺�
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "insert into teacher(teano,teaname,sex,age,degree,rank,teatel,teaaddress,remark,type)";
            strSql += "values('" + objTea.TeaNo + "','" + objTea.TeaName + "','" + objTea.Sex + "','" + objTea.Age + "',";
            strSql += "'" + objTea.Degree + "','" + objTea.Rank + "','" + objTea.TeaTel + "','" + objTea.TeaAddress + "','" + objTea.Remark + "',1)  ";
            strSql += "insert into users (userno,username,password,rights,type) values ('" + objTea.TeaNo + "','" + objTea.TeaName + "','" + objTea.TeaNo + "',2,1)  ";
            sqlCom.CommandText = strSql;
            try
            {
                sqlCon.Open();
                sqlCom.Connection = sqlCon;
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
        //ɾ����ʦ��Ϣ�ķ���:public int DelTea(string strTeaNo, out string strErr)   
       //ɾ����ʦ���˺�,string strTeaNo�Ƕ�����ս�ʦ��ŵı���, out string strErr���岶�����ı�����������ֵΪ1ʱ��ɾ���ɹ���������ֵΪ0ʱ�������򽫴��󸳸�strErr��
      // ɾ����ʦ��Ϣͬʱɾ���˺���Ϣͬʱɾ����ʦ�γ̼�¼����ʦ�༶��¼
        public int DelTea(string strTeaNo, out string strErr)                                                      
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "update teacher  set type=0 where teaNo ='" + strTeaNo.Replace("'", "''") + "'   ";
            strSql += "update teacher_course set type =0 where teaid in(select teaId from teacher where teaNo ='" + strTeaNo.Replace("'", "''") + "') ";
            strSql += "update class_teacher set type =0 where teaid in(select teaId from teacher where teaNo ='" + strTeaNo.Replace("'", "''") + "')  ";
            strSql += "update users set type =0 where username='" + strTeaNo.Replace("'", "''").ToString() + "'";
            sqlCom.CommandText = strSql;
            try
            {
                sqlCon.Open();
                sqlCom.Connection = sqlCon;
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

        //�޸Ľ�ʦ��Ϣ�ķ���,public int ModifyTea(string strTeaNo, Model.Teacher.Teacher objTea, out string strErr)     
       //int iTeaId�Ǵ���Ľ�ʦID�� string strOld�Ǵ���ľɵĽ�ʦ��ţ�
      //Model.teacher.teacher objTea��ģ���࣬ out string strErr���岶�����ı���
     //int Ϊ1���޸ĳɹ���ͬʱ�޸��û��ɹ���ģ����洢��ʦ�������Ϣ��Ϊ0�򷵻ش�����ʾ�������󸳸�strErr��       
        public int ModifyTea(string strTeaNo, Model.Teacher.Teacher objTea, out string strErr)                         //�޸Ľ�ʦ��Ϣͬʱ�޸��˺���Ϣ
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            objTea.TeaNo = objTea.TeaNo.Replace("'", "''");
            objTea.TeaNo.Trim();
            objTea.TeaName = objTea.TeaName.Replace("'", "''");
            objTea.TeaName.Trim();
            objTea.TeaTel = objTea.TeaTel.Replace("'", "''");
            objTea.TeaTel.Trim();
            objTea.TeaAddress = objTea.TeaAddress.Replace("'", "''");
            objTea.TeaAddress.Trim();
            objTea.Remark = objTea.Remark.Replace("'", "''");
            objTea.Remark.Trim();
            strTeaNo = strTeaNo.Replace("'", "''");
            strTeaNo = strTeaNo.Trim();
            string strSql = "update teacher  ";
            strSql += "set teano='" + objTea.TeaNo + "',teaname='" + objTea.TeaName + "',sex='" + objTea.Sex + "',age = '" + objTea.Age + "',";
            strSql += "degree='" + objTea.Degree + "',rank='" + objTea.Rank + "',teatel='" + objTea.TeaTel + "',teaaddress='" + objTea.TeaAddress + "',remark='" + objTea.Remark + "' where teaNo ='" + strTeaNo.ToString() + "' and type =1 ";
            strSql += "  update users set username='" + objTea.TeaNo + "',password='" + objTea.TeaNo + "' where username='" + strTeaNo.Replace("'", "''").ToString() + "'and type=1 ";
            sqlCom.CommandText = strSql;
            try
            {
                sqlCon.Open();
                sqlCom.Connection = sqlCon;
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

        //��ѯ��ʦ��Ϣ������
       //public int SearchTea (out DataTable objDataTable ,out string strErr) 
      //out DataTable objDataTable������һ����
     //out string strErr ���岶�����ı�����������ֵΪ1���ѯ�ɹ�������ı���ʾ��ѯ���������ֵΪ0 ������������󸳸�strErr��
  
        public int SearchTea(out DataTable objDataTable, out string strErr)                                                     
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "select teano ��ʦ���,teaname ��ʦ����,sex �Ա�,age ����,degree ѧ��,rank ְ��,teatel ��ϵ��ʽ,teaaddress סַ,remark ��ע from teacher where type=1";
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

                           
          //���ݽ�ʦ��š���ʦ�������в�ѯ
         //string strTeaNo������ս�ʦ��ŵı���
        //string strTeaName������ս�ʦ�����ı���
       //out DataTable objDataTable������һ����
      //out string strErr ���岶�����ı�����������ֵΪ1ʱ�����ݴ���Ľ�ʦ��źͽ�ʦ������ѯ�ɹ�������ѯ�����������ֵΪ0���򽫴��󸳸�strErr                                             
        public int SearchTea(string strTeaNo, string strTeaName, out DataTable objDataTable, out string strErr)                 
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "select teaid ��ʦID,teano ��ʦ���,teaname ��ʦ����,sex �Ա�,age ����,degree ѧ��,rank ְ��,teatel ��ϵ��ʽ,teaaddress סַ,remark ��ע ";
            strSql += "  from teacher  where  type=1 and teano like '%" + strTeaNo + "%' escape'\\'  and teaname like  '%" + strTeaName + "%' escape'\\'";
            sqlCom.CommandText = strSql;
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

        public int StuSearchAllTea(string StuNo, out DataTable objDataTable, out string strErr)                                  //ѧ����ѯ�����ڿν�ʦ��¼
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "select distinct a.teano ��ʦ���, a.teaname ��ʦ����,a.sex �Ա�,a.age ����,a.degree ѧ��,a.rank ְ��,a.teatel ��ϵ��ʽ,a.teaaddress סַ ";
            strSql += "from teacher a,class_teacher b,student c where  ";
            strSql += "c.classid in (select classid from student where stuno='" + StuNo + "') ";
            strSql += "and c.classid=b.classid and a.teaid= b.teaid and a.type=1 and b.type=1 and c.type=1 ";
            sqlCom.CommandText = strSql;
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlDa.SelectCommand = sqlCom;
            try
            {
                sqlCom.Connection = sqlCon;
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
        public int StuSearchOneTeaNo(string TeaNo, string TeaName, string StuNo, out DataTable objDataTable, out string strErr)   //ѧ�����ݽ�ʦ��š���ʦ������ѯ�ڿν�ʦ��¼
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "select distinct a.teano ��ʦ���, a.teaname ��ʦ����,a.sex �Ա�,a.age ����,a.degree ѧ��,a.rank ְ��,a.teatel ��ϵ��ʽ,a.teaaddress סַ ";
            strSql += "from teacher a,class_teacher b,student c where  ";
            strSql += "c.classid in (select classid from student where stuno='" + StuNo + "') and a.teano like '%" + TeaNo + "%' escape'\\' and teaname like  '%" + TeaName + "%' escape'\\' ";
            strSql += "and c.classid=b.classid and a.teaid= b.teaid  and a.type=1 and b.type=1 and c.type=1 ";
            sqlCom.CommandText = strSql;
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlDa.SelectCommand = sqlCom;
            try
            {
                sqlCom.Connection = sqlCon;
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
        public int JudgeTeaNo(string TeaNo)                                                                                      //�жϽ�ʦ�Ƿ����ʦ����ظ�
        {
            string strErr = "";
            SqlCommand sqlcom = new SqlCommand();
            TeaNo = TeaNo.Replace("'", "''");
            TeaNo = TeaNo.Trim();
            string strSql = "select distinct  teano from teacher where teano='" + TeaNo.ToString() + "' and type =1";
            sqlcom.CommandText = strSql;
            sqlcom.Connection = sqlCon;
            DataSet ds = new DataSet();
            sqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(strSql, sqlCon);
            try
            {
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
            }
            finally
            {
                sqlCon.Close();
                sqlcom.Dispose();
            }
            if (ds.Tables[0].Rows.Count != 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int JudgeTeaNoLikeStuNo(string TeaNo)                                                                                      //�жϽ�ʦ����Ƿ���ѧ������ظ�
        {
            string strErr = "";
            SqlCommand sqlcom = new SqlCommand();
            TeaNo = TeaNo.Replace("'", "''");
            TeaNo = TeaNo.Trim();
            string strSql = "select distinct  stuno from student where stuno='" + TeaNo.ToString() + "' and type =1";
            sqlcom.CommandText = strSql;
            sqlcom.Connection = sqlCon;
            DataSet ds = new DataSet();
            sqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(strSql, sqlCon);
            try
            {
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
            }
            finally
            {
                sqlCon.Close();
                sqlcom.Dispose();
            }
            if (ds.Tables[0].Rows.Count != 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
