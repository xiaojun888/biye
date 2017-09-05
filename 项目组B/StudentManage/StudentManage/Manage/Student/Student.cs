using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//dt.Rows.Count

namespace Manage.Student
{
    public class Student
    {
        SqlConnection sqlCon;
        public Student(string strConectionString)
        {
            sqlCon = new SqlConnection(strConectionString);
        }

        //�жϰ༶�Ƿ����,������ڷ���1�������ڷ���0
        public int JudgeClassExist()
        {
            string strErr = "";
            SqlCommand sqlcom = new SqlCommand();
            string strSql = "select distinct * from Class where Type=1";
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
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //����ѧ�����˺�
        public int AddStu(Model.Student.Student objStudent, out string strErr)
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "insert into student(classid,stuno,stuname,sex,birthdate,entrancetime,stutel,stuaddress,remark,type)";
            strSql += "values(" + objStudent.ClassId + ",'" + objStudent.StuNo + "','" + objStudent.StuName + "','" + objStudent.Sex + "','" + objStudent.BirthDate.ToShortDateString() + "',";
            strSql += "'" + objStudent.EntranceTime.ToShortDateString() + "','" + objStudent.StuTel + "','" + objStudent.StuAddress + "','" + objStudent.Remark + "',1)  ";
            strSql += "insert into users(userno,username,password,rights,type) values ('" + objStudent.StuNo + "','" + objStudent.StuName + "','" + objStudent.StuNo + "',3,1);";
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

        //ͨ����ѯ��ӵ�ѧ����Ŵ���������ж��ܷ���ӣ�����Ѵ��ڷ���1,�����ڷ���0      
        public int JudgeStuNo(string StuNo)
        { 
            string strErr = "";
            SqlCommand sqlcom = new SqlCommand();
            string strSql = "select stuno from student where stuno='" + StuNo.ToString() + "' and type =1";
            sqlcom.CommandText = strSql;
            sqlcom.Connection = sqlCon;
            DataSet ds = new DataSet();
            
            SqlDataAdapter da = new SqlDataAdapter(strSql, sqlCon);
            try
            {
                sqlCon.Open();
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
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //ɾ��ѧ�����˺�
        public int DelStu(string strStuNo, out string strErr)
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strSql = " update student set type=0  where stuno ='" + strStuNo.Replace("'", "''") + "'  ";
            strSql += "update users set type=0 where userno ='" + strStuNo.Replace("'", "''") + "'  ";
            strSql += "update score set type=0 where stuid in (select stuid from student where stuno='" + strStuNo.Replace("'", "''") + "' )";
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

        //�޸�ѧ����Ϣͬʱ�޸��˺�        
        public int ModifyStu(string stu, string studentno, Model.Student.Student objStudent, out string strErr)
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "update student ";
            strSql += "set classid=" + objStudent.ClassId.ToString() + ",stuno='" + objStudent.StuNo + "',stuname='" + objStudent.StuName + "',sex='" + objStudent.Sex + "',birthdate='" + objStudent.BirthDate.ToShortDateString() + "',";
            strSql += "entrancetime='" + objStudent.EntranceTime.ToShortDateString() + "',stutel='" + objStudent.StuTel + "',stuaddress='" + objStudent.StuAddress + "',remark='" + objStudent.Remark + "' where stuno ='" + stu + "' and type=1  ";
            strSql += " update users set userno ='" + objStudent.StuNo + "',username ='" + objStudent.StuName + "',password='" + objStudent.StuNo + "' where userno='" + stu + "'  and type=1 ";
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

        //����Ա��ѯ���м�¼,��ʦ��ѯ�Լ������༶ѧ����Ϣ��ѧ����ѯ�Լ��༶ѧ����Ϣ
        public int SearchStuAll(int iRight, string strUserNo,out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
             string strSql = "";
             if (iRight == 1)
             {
                 strSql = "select student.stuno ѧ�����,student.stuname ѧ������,class.classname ���ڰ༶ ,student.sex �Ա�,student.birthdate ��������,student.entrancetime ��ѧʱ��, ";
                 strSql += "student.stutel ��ϵ��ʽ,student.stuaddress סַ,student.remark ��ע from student,class where student.classid=class.classid and student.type=1 and class.type=1  ";
             }
             if (iRight == 2)
             {
                  //strSql = "select student.stuno ѧ�����,student.stuname ѧ������,class.classname ���ڰ༶ ,student.sex �Ա�,student.birthdate ��������,student.entrancetime ��ѧʱ��, ";
                  //strSql += "student.stutel ��ϵ��ʽ,student.stuaddress סַ,student.remark ��ע from student,class where student.classid=class.classid and student.type=1 and class.type=1  ";
             

                 strSql = "select a.stuno ѧ�����, b.classname ���ڰ༶,a.stuname ѧ������,a.sex �Ա�,a.birthdate ��������,a.entrancetime ��ѧʱ�� ,a.stutel ��ϵ��ʽ, ";
                 strSql += "a.stuaddress סַ from student a ,class b  where a.classid in(select  distinct classid from class_teacher where  teaid  in (select ";
                 strSql += "teaid from teacher where teano='" + strUserNo + "' and type=1) and type=1) and a.classid=b.classid and a.type=1 and b.type=1  ";                         
             }
             if (iRight == 3)
             {

                // strSql = "select student.stuno ѧ�����,student.stuname ѧ������,class.classname ���ڰ༶ ,student.sex �Ա�,student.birthdate ��������,student.entrancetime ��ѧʱ��, ";
                // strSql += "student.stutel ��ϵ��ʽ,student.stuaddress סַ,student.remark ��ע from student,class where student.classid=class.classid and student.type=1 and class.type=1  ";
                 strSql = "select distinct a.stuno ѧ�����,a.stuname ѧ������,b.classname ���ڰ༶ ,a.sex �Ա�,a.birthdate ��������,a.entrancetime ��ѧʱ��, ";
                 strSql += "a.stutel ��ϵ��ʽ,a.stuaddress סַ from student a ,class b where b.type=1 and a.classid=b.classid and  ";
                 strSql += "a.type=1 and a.classid in ( select classid from student where stuno='" + strUserNo + "' and type=1) ";
             }
            
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

        //����Ա�ͽ�ʦ����ѧ�����,ѧ������,�༶���ƽ���ģ����ѯ,ѧ������ѧ����š�ѧ����������ģ����ѯ
        public int SearchStuBy(int iRight,string strUserNo,string strStuNo,string strStuName,string strClassName,out DataTable objDataTable,out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "";
            
            if (iRight == 1)
            {
              strSql = "select student.stuno ѧ�����,student.stuname ѧ������,class.classname ���ڰ༶ ,student.sex �Ա�,student.birthdate ��������,student.entrancetime ��ѧʱ��, ";
              strSql += "student.stutel ��ϵ��ʽ,student.stuaddress סַ,student.remark ��ע from student,class where student.classid=class.classid and student.type=1 and class.type=1  ";
              strSql += "and student.stuno like '%" + strStuNo + "%' escape '\\'  and student.stuname like '%" + strStuName + "%' escape '\\'  and  student.classid in (select classid from class where classname like '%" + strClassName + "%' escape '\\' and type=1  )";
            }
            if (iRight == 2)
            {
                strSql = "select a.stuno ѧ�����, b.classname ���ڰ༶,a.stuname ѧ������,a.sex �Ա�,a.birthdate ��������,a.entrancetime ��ѧʱ�� ,a.stutel ��ϵ��ʽ, ";
                strSql += "a.stuaddress סַ from student a ,class b where a.classid in(select  distinct classid from class_teacher where  teaid  ";
                strSql += "in (select teaid from teacher where teano='" + strUserNo + "' and type=1) and type=1) and a.type=1 and a.classid= b.classid ";
                strSql += "and b.type=1  and a.stuno like '%" + strStuNo + "%' escape '\\' and a.stuname like '%" + strStuName + "%' escape '\\'";
                strSql += " a.classid  in (select classid  from class where  classname like '%" + strClassName + "%' escape '\\'and type=1)";
            }
            if (iRight == 3)
            {
                strSql = "select distinct a.stuno ѧ�����,a.stuname ѧ������,b.classname ���ڰ༶ ,a.sex �Ա�,a.birthdate ��������,a.entrancetime ��ѧʱ��,a.stutel ��ϵ��ʽ, ";
                strSql += "a.stuaddress סַ from student a ,class b where b.type=1 and a.classid=b.classid and a.type=1 and a.classid in ( select classid from student ";
                strSql += " where stuno='" + strUserNo + "' and type=1) and stuno like '%" + strStuNo + "%' escape '\\' and stuname like '%" + strStuName + "%' escape '\\'";
            }            
            sqlCom.CommandText = strSql;
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlDa.SelectCommand = sqlCom;
            //sqlCom.Connection = sqlCon;
            try
            {
                sqlCom .Connection = sqlCon;
                //�˴��д���
               
                sqlDa.Fill(objDataTable);
                //sqlDa.Fill(objDataTable);
                //dt.Rows.Count
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


        //�ж�ѧ������Ƿ����ʦ����ظ�
        public int JudgeStuNoLikeTeaNo(string StuNo)
        {
            string strErr = "";
            SqlCommand sqlcom = new SqlCommand();
            string strSql = "select teano from teacher where teano='" + StuNo.ToString() + "' and type =1";
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
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int SearchStu1(out DataTable objDataTable, out string strErr)    //��ѧ����ѯ���м�¼
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "";
            strSql = "select student.stuid ѧ��ID,student.stuno ѧ�����,student.stuname ѧ������,class.classname ���ڰ༶ ,student.sex �Ա�,student.birthdate ��������,student.entrancetime ��ѧʱ��, ";
            strSql += "student.stutel ��ϵ��ʽ,student.stuaddress סַ,student.remark ��ע from student,class where student.classid=class.classid and student.type=1 and class.type=1  ";

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

        //�ɼ��л����õ���
        public int SearchStudent3(out DataTable objDataTable, out string strErr)
        {
            objDataTable = new DataTable();
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "select StuId,StuNo from Student where Type=1";
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
