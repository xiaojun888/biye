using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Manage.Teacher_Course_Class
{
    public class T_C_C
    {
        public int teaId;
        SqlConnection sqlCon;
        public T_C_C(string strConnection)
        {
            sqlCon = new SqlConnection(strConnection);
        }

                                                                                
         //��ӽ�ʦ�ķ���: 
        //Model.Teacher_Class.Teacher_Class objTClass Model.teacher.teacher objTea��ģ���࣬
       //out string strErr���岶�����ı�����int Ϊ1����ӳɹ���ģ����洢��ʦ�ɺͽ�ʦ�γ̰༶�Լ��γ̰༶�������Ϣ��Ϊ0�򷵻ش�����ʾ�������󸳸�strErr
        public int AddTeacherC_C(Model.Teacher_Course.Teacher_Course objTeacherCourse, Model.Teacher_Class.Teacher_Class objTClass, int iTeaId, out string strErr)                   //���ӽ�ʦ���༶���γ���Ϣ
        {
            strErr = "";
            int iReturn = 0;
            SqlCommand sqlcom = new SqlCommand();
            teaId = iTeaId;
            string strSql = "insert into Teacher_Course(CourseID,TeaId,type) values(" + objTeacherCourse.CourseId + "," + teaId + ",1)  ";
            strSql += " insert into Class_Teacher (classid,teaid,type) values(" + objTClass.ClassId + "," + teaId + ",1)  ";
            strSql += "insert into class_course (classid ,courseid,type ) values (" + objTClass.ClassId + "," + objTeacherCourse.CourseId + ",1)";
            sqlcom.CommandText = strSql;
            sqlcom.Connection = sqlCon;
            try
            {
                sqlCon.Open();
                sqlcom.ExecuteNonQuery();
                iReturn = 1;
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
                iReturn = 0;
            }
            finally
            {
                sqlCon.Close();
                sqlcom.Dispose();
            }
            return iReturn;
        }

         //��ѯ��ʦ��Ϣ�ķ���:
        //public int SearchTCC(out DataTable objDataTable, out string strErr)  
       //out DataTable objDataTable������һ����
      //out string strErr ���岶�����ı�����������ֵΪ1���ѯ�ɹ�������ı���ʾ��ѯ���������ֵΪ0 ������������󸳸�strErr��
        public int SearchTCC(out DataTable objDataTable, out string strErr)                                                                                              //��ѯ��ʦ���༶���γ���Ϣ
        {
            strErr = "";
            int iReturn = 0;
            objDataTable = new DataTable();
            SqlCommand sqlcom = new SqlCommand();
            string strSql = "select distinct a.teano ��ʦ���, a.teaname ��ʦ����,b.coursename �γ�����,b.courseNo �γ̱��,c.classname �༶����,c.classNo �༶���";
            strSql += " from teacher a ,course b,class c,Teacher_Course d, Class_Teacher e , class_course f where   ";
            strSql += "a.type=1 and b.type=1 and c.type=1 and d.type=1 and e.type=1 and f.type=1  and  ";
            strSql += "a.teaid=d.teaid and a.teaid=e.teaid  and b.courseid=d.courseid and b.courseid=f.courseid   ";
            strSql += "and c.classid=e.classid and c.classid =f.classid and d.courseid=f.courseid and e.classid=f.classid ";
            sqlcom.CommandText = strSql;
            sqlcom.Connection = sqlCon;
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlDa.SelectCommand = sqlcom;
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
                sqlCon.Close();
                sqlcom.Dispose();
            }
            return iReturn;
        }

                                                                                                  
        //ɾ����ʦ��Ϣ�ķ���:public int DelTCC(string TeaNo, string ClassNo, string CourseNo, out string strErr)  
       //ɾ����ʦְ����Ϣ,string TeaNo�Ƕ�����ս�ʦ��ŵı���,
      //string ClassName�����˽��հ༶���Ƶı���, string CourseName�����˽��տγ����Ƶı���,
     //out string strErr���岶�����ı�����������ֵΪ1ʱ��ɾ���ɹ���������ֵΪ0ʱ�������򽫴��󸳸�strErr
       
        public int DelTCC(string TeaNo, string ClassNo, string CourseNo, out string strErr)                                                                           //ɾ����ʦ���༶���γ���Ϣ
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strTeaNo = TeaNo.Replace("'", "''");
            string strClassNo = ClassNo.Replace("'", "''");
            string strCourseNo = CourseNo.Replace("'", "''");
            string strSql = "update Teacher_Course set type=0  where teaid =(select teaid from teacher where teano='" + strTeaNo + "') and courseid=(select courseid from course where courseno='" + strCourseNo + "') ";
            strSql += "update Class_Teacher set type=0  where teaid in(select teaid from teacher where teano='" + strTeaNo + "') and classid=(select classid from class where classno='" + strClassNo + "')  ";
            strSql += "update class_course set type =0 where classid in(select classid from class where classno='" + strClassNo + "') and courseid=(select courseid from course where courseno='" + strCourseNo + "') ";
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

         //�޸Ľ�ʦ��Ϣ�ķ���:                     
        // public int ModifyTCC(string TeaNo, int OldClassid, int OldCourseid, Model.Teacher_Class.Teacher_Class objTCl, Model.Teacher_Course.Teacher_Course objTCo, out string strErr)
       //�޸Ľ�ʦ���̰༶��string TeaNo������ս�ʦ��ŵı���,int OldClassid������վɵİ༶ID�ı���,int OldCourseid������վɵĿγ�ID�ı���,
      //Model.Teacher_Course.Teacher_Course objTCo, Model.Teacher_Class.Teacher_Class objTCl, Model.teacher.teacher objTea��ģ���࣬
     //out string strErr���岶�����ı���������ֵ Ϊ1����ӳɹ���ģ����洢��ʦ�ͽ�ʦ�γ̰༶�Լ��γ̰༶�������Ϣ��Ϊ0�򷵻ش�����ʾ�������󸳸�strErr�� 

        public int ModifyTCC(string TeaNo, int OldClassid, int OldCourseid, Model.Teacher_Class.Teacher_Class objTCl, Model.Teacher_Course.Teacher_Course objTCo, out string strErr) //ֻ�޸Ľ�ʦ���̰༶�����޸Ľ�ʦ���̿γ�       
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "update class_teacher set classid= " + objTCl.ClassId + " where cl_teaid =( select cl_teaid from class_teacher where classid=" + OldClassid + " and ";
            strSql += " teaid in (select teaid from teacher where teano= '" + TeaNo + "' and type=1) and type=1) and type =1  ";
            strSql += "update class_course  set classid=" + objTCl.ClassId + " where cl_coid = (select cl_coid from class_course where classid=" + OldClassid + "and  courseid= " + OldCourseid + "and type =1) and type =1 ";
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

        //�޸Ľ�ʦ���̿γ̣�string TeaNo������ս�ʦ��ŵı���,int OldClassid������վɵİ༶ID�ı���,int OldCourseid������վɵĿγ�ID�ı���,
       //Model.Teacher_Course.Teacher_Course objTCo, Model.Teacher_Class.Teacher_Class objTCl, Model.teacher.teacher objTea��ģ���࣬
      //out string strErr���岶�����ı���������ֵ Ϊ1����ӳɹ���ģ����洢��ʦ�ɺͽ�ʦ�γ̰༶�Լ��γ̰༶�������Ϣ��Ϊ0�򷵻ش�����ʾ�������󸳸�strErr��
        public int ModifyTCC1(string TeaNo, int OldClassid, int OldCourseid, Model.Teacher_Class.Teacher_Class objTCl, Model.Teacher_Course.Teacher_Course objTCo, out string strErr)   //ֻ�޸Ľ�ʦ���̿γ̣����޸Ľ�ʦ���̰༶       
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "update teacher_course set courseid= " + objTCo.CourseId + " where tea_coid=(select tea_coid from teacher_course where teaid in (select teaid from teacher where teano= '" + TeaNo + "'and type=1) ";
            strSql += " and  courseid =" + OldCourseid + " and type =1) ";
            strSql += "update class_course set courseid =" + objTCo.CourseId + " where cl_coid=( select cl_coid from class_course  where classid =" + OldClassid + "and  courseid =" + OldCourseid + " and type=1 ) and type=1 ";
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
        public int JudgeClassCourse(int CourseId, int ClassId)                                                                                                            //�жϰ༶���γ���Ϣ�Ƿ����
        {
            string strErr = "";
            SqlCommand sqlcom = new SqlCommand();
            string strSql = "select distinct a.teaid from teacher_course a, class_course b,class_teacher c   ";
            strSql += " where a.type=1 and b.type=1 and c.type=1 and a.teaid=c.teaid ";
            strSql += " and a.courseid =b.courseid and b.classid=c.classid and a.courseid=" + CourseId.ToString() + "and c.classid= " + ClassId.ToString() + "";
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
            if (ds.Tables[0].Rows.Count == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int JudgeTeaClassCourse(int TeaId, int courseid, int classid)                                                                                             //�жϽ�ʦ���γ̡��༶��Ϣ�Ƿ��Ѿ�����
        {
            string strErr = "";
            SqlCommand sqlcom = new SqlCommand();
            string strSql = "select distinct a.courseid from teacher_course a ,class_teacher b ,class_course c  where a.teaid=" + TeaId + " and a.type =1 and b.type=1 and c.type=1 ";
            strSql += "and a.courseid=" + courseid + " and b.classid=" + classid + " and a.teaid=b.teaid and a.courseid = c.courseid  and b.classid =c.classid ";
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
            if (ds.Tables[0].Rows.Count == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int SearchTCC1(string TeaNo, string TeaName, string CourseName, string ClassName, out DataTable objDataTable, out string strErr)                             //ģ����ѯ��ʦ���༶���γ���Ϣ
        {
            strErr = "";
            int iReturn = 0;
            objDataTable = new DataTable();
            SqlCommand sqlcom = new SqlCommand();
            string strSql = "select distinct a.teaid ��ʦID,a.teano ��ʦ���, a.teaname ��ʦ����,b.coursename ���̿γ�,c.classname ���̰༶  ";
            strSql += " from teacher a ,course b,class c,Teacher_Course d, Class_Teacher e , class_course f where   ";
            strSql += "a.type=1 and b.type=1 and c.type=1 and d.type=1 and e.type=1 and f.type=1  and  ";
            strSql += "a.teaid=d.teaid and a.teaid=e.teaid  and b.courseid=d.courseid and b.courseid=f.courseid   ";
            strSql += "and c.classid=e.classid and c.classid =f.classid and d.courseid=f.courseid and e.classid=f.classid ";
            strSql += " and a.teano like '%" + TeaNo + "%' escape '\\'   and  a.teaname like '%" + TeaName + "%' escape '\\'  and b.coursename like '%" + CourseName + "%' escape '\\'   and  c.classname like '%" + ClassName + "%' escape '\\' ";
            sqlcom.CommandText = strSql;
            sqlcom.Connection = sqlCon;
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlDa.SelectCommand = sqlcom;
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
                sqlCon.Close();
                sqlcom.Dispose();
            }
            return iReturn;
        }
        public int JudgeClassExist()                                                                                                                                     //�жϰ༶�Ƿ����
        {
            string strErr = "";
            SqlCommand sqlcom = new SqlCommand();
            string strSql = "select distinct * from class where type=1 ";
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
        public int JudgeCourseExist()                                                                                                                                     //�жϿγ��Ƿ����
        {
            string strErr = "";
            SqlCommand sqlcom = new SqlCommand();
            string strSql = "select distinct * from course where type=1 ";
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
        public int GetTeaId(string strTeaNo)                                                                                                                                     //����teaId
        {
            string strErr = "";
            SqlCommand sqlcom = new SqlCommand();
            string teaNo = strTeaNo.Replace("'", "''");
            string strSql = "select  * from teacher where type=1 and teaNo ='" + teaNo + "' ";
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

            DataRow dr = ds.Tables[0].Rows[0];
            teaId = int.Parse(dr["teaId"].ToString());
            return teaId;


        }
        public int JudgeTeaClass(string TeaNo, string ClassNo, out string strErr)
        {
            int iRent = 0;
            try
            {
                DataTable dt = new DataTable();
                SqlCommand sqlCom = new SqlCommand();
                string strSql = "select count(*) from Class_Teacher  where teaid in(select teaid from teacher where teano='" + TeaNo + "') and classid=(select classid from class where classno='" + ClassNo + "')  ";
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = strSql;
                strErr = "";
                string strTeaNo = TeaNo.Replace("'", "''");
                string strClassNo = ClassNo.Replace("'", "''");
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlCom;
                da.Fill(dt);
                iRent = dt.Rows.Count;
            }
            catch (Exception exErr)
            {
                strErr = exErr.ToString();

            }           
            return iRent;
        }
        public int JudgeTeaCourse(string TeaNo, string CourseNo, out string strErr)
        {
            int iRent = 0;
            try
            {
                DataTable dt = new DataTable();
                SqlCommand sqlCom = new SqlCommand();
                string strSql = "select count(*) from Teacher_course  where teaid in(select teaid from teacher where teano='" + TeaNo + "') and courseid=(select courseid from course where courseno='" + CourseNo + "')  ";
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = strSql;
                strErr = "";
                string strTeaNo = TeaNo.Replace("'", "''");
                string strClassNo = CourseNo.Replace("'", "''");
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlCom;
                da.Fill(dt);
                iRent = dt.Rows.Count;
            }
            catch (Exception exErr)
            {
                strErr = exErr.ToString();

            }
            return iRent;
        }
        public int JudgeClassCourse(string CourseNo, string ClassNo, out string strErr)
        {
            int iRent = 0;
            try
            {
                DataTable dt = new DataTable();
                SqlCommand sqlCom = new SqlCommand();
                string strSql = "select count(*) from Class_Course  where courseId in(select courseid from course where courseno='" + CourseNo + "') and classid=(select classid from class where classno='" + ClassNo + "')  ";
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = strSql;
                strErr = "";
                string strTeaNo = CourseNo.Replace("'", "''");
                string strClassNo = ClassNo.Replace("'", "''");
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlCom;
                da.Fill(dt);
                iRent = dt.Rows.Count;
            }
            catch (Exception exErr)
            {
                strErr = exErr.ToString();

            }
            return iRent;
        }
        public int AddTeacherCourse(Model.Teacher_Course.Teacher_Course objTeacherCourse, int iTeaId, out string strErr)                   //���ӽ�ʦ���༶���γ���Ϣ
        {
            strErr = "";
            int iReturn = 0;
            SqlCommand sqlcom = new SqlCommand();
            teaId = iTeaId;
            string strSql = "insert into Teacher_Course(CourseID,TeaId,type) values(" + objTeacherCourse.CourseId + "," + teaId + ",1)  ";
            sqlcom.CommandText = strSql;
            sqlcom.Connection = sqlCon;
            try
            {
                sqlCon.Open();
                sqlcom.ExecuteNonQuery(); 
                iReturn = 1;
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
                iReturn = 0;
            }
            finally
            {
                sqlCon.Close();
                sqlcom.Dispose();
            }
            return iReturn;
        }

        public int AddTeacherClass(Model.Teacher_Class.Teacher_Class objTClass, int iTeaId, out string strErr)                   //���ӽ�ʦ���༶���γ���Ϣ
        {
            strErr = "";
            int iReturn = 0;
            SqlCommand sqlcom = new SqlCommand();
            teaId = iTeaId;
            string strSql = " insert into Class_Teacher (classid,teaid,type) values(" + objTClass.ClassId + "," + teaId + ",1)  ";
            sqlcom.CommandText = strSql;
            sqlcom.Connection = sqlCon;
            try
            {
                sqlCon.Open();
                sqlcom.ExecuteNonQuery();
                iReturn = 1;
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
                iReturn = 0;
            }
            finally
            {
                sqlCon.Close();
                sqlcom.Dispose();
            }
            return iReturn;
        }
        public int AddClassCourse(Model.Teacher_Course.Teacher_Course objTeacherCourse, Model.Teacher_Class.Teacher_Class objTClass, int iTeaId, out string strErr)                   //���ӽ�ʦ���༶���γ���Ϣ
        {
            strErr = "";
            int iReturn = 0;
            SqlCommand sqlcom = new SqlCommand();
            teaId = iTeaId;
            string strSql = "insert into class_course (classid ,courseid,type ) values (" + objTClass.ClassId + "," + objTeacherCourse.CourseId + ",1)";
            sqlcom.CommandText = strSql;
            sqlcom.Connection = sqlCon;
            try
            {
                sqlCon.Open();
                sqlcom.ExecuteNonQuery();
                iReturn = 1;
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
                iReturn = 0;
            }
            finally
            {
                sqlCon.Close();
                sqlcom.Dispose();
            }
            return iReturn;
        }
    }
}
