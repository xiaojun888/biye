using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Manage.Course
{
    public class Course
    {
        SqlConnection sqlCon;
        public Course(string strSqlConnection)
        {
            sqlCon = new SqlConnection(strSqlConnection);
        }


        //���ӿγ�
        public int AddCourse(Model.Course.Course objCourse, out string strErr)
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "insert into Course(CourseNo,CourseName,Points,Remark,Type)";
            strSql += "values('" + objCourse.CourseNo + "','" + objCourse.CourseName + " ','" + objCourse.Points.ToString() + "' ,'" + objCourse.Remark + "',1)";


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

        //ͨ����ѯ����Ŀγ̱���Ƿ�������ж��ܷ���ӵ�ǰ�γ̣�����Ѵ��ڷ���1,�����ڷ���0
        public int JudgeCourseNo(string CourseNo,out string strErr)
        {
            strErr = "";
            SqlCommand sqlcom = new SqlCommand();
            string strSql = "select CourseId from Course where CourseNo = '" + CourseNo.ToString() + "' and Type =1 ";
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

        //ͨ����ѯ����Ŀγ������Ƿ�������ж��ܷ���ӵ�ǰ�γ̣�����Ѵ��ڷ���1,�����ڷ���0
        public int JudgeCourseName(string CourseName, out string strErr)
        {
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "select CourseId from course where CourseName = '" + CourseName.ToString() + "' and Type =1 ";
            sqlCom.CommandText = strSql;
            sqlCom.Connection = sqlCon;
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

        //ɾ���γ�
        public int DelCourse(string strCourseNo, out string strErr)
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "update Course set Type=0  where CourseNo ='" + strCourseNo.Replace("'", "''") + "'";
            strSql += " update Teacher_Course set Type=0 where CourseId in (select CourseId from Course where CourseNo ='" + strCourseNo.Replace("'", "''") + "' )";
            strSql += " update Class_Course set Type=0  where CourseId in (select CourseId from Course where CourseNo ='" + strCourseNo.Replace("'", "''") + "' )";
            strSql += " update Score set Type=0 where CourseId in (select CourseId from Course where CourseNo ='" + strCourseNo.Replace("'", "''") + "' )";
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

        //�޸Ŀγ�
        public int ModifyCourse(string  strCourseNumber, Model.Course.Course objCourse, out string strErr)
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = sqlCon;
            string strSql = "update Course set CourseNo='" + objCourse.CourseNo + "',CourseName='" + objCourse.CourseName + "', ";
            strSql += " Points='" + objCourse.Points.ToString() + "',Remark='" + objCourse.Remark + "' where CourseNo='" + strCourseNumber + "'";
            sqlCom.CommandText = strSql;

            try
            {
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
                iRent = 1;
            }
            catch (Exception ex)
            {
                strErr = ex.ToString();
                iRent = 0;
            }
            finally
            {
                sqlCon.Close();
                sqlCom.Dispose();
            }
            return iRent;
        }

        //����Ա��ѯ���пγ̣���ʦ��ѯ�Լ�������ѧ����ѯ�Լ�����
        public int SearchCourseAll(int iRight, string strUserNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();

            string strSql = "";
            if (iRight == 1)
            {
                strSql = "select CourseNo �γ̱��,CourseName �γ�����,Points ѧ��,Remark ��ע from Course where Type=1";
            }
            if (iRight == 2)
            {
                strSql = "select CourseNo �γ̱��,CourseName �γ�����,Points ѧ��,Remark ��ע from Course where Type=1 and CourseId in (select CourseId from Teacher_Course where TeaId in (select TeaId from Teacher where TeaNo ='" + strUserNo + "'))";
            }
            if (iRight == 3)
            {
                strSql = "select CourseNo �γ̱��,CourseName �γ�����,Points ѧ��,Remark ��ע from Course where Type=1 and CourseId in (select CourseId from Class_Course where ClassId in (select ClassId from Student where StuNo ='" + strUserNo + "'))";
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
        public int SearchCourse1( out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "";
            strSql = "select CourseId �γ�ID,CourseNo �γ̱��,CourseName �γ�����,Points ѧ��,Remark ��ע from Course where Type=1";
            sqlCom.CommandText = strSql;
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
        //��ʦְ�����÷���

        //����Ա����ʦ���ݿγ̱��,�γ�����,�༶����ģ����ѯ��ѧ�����ݸ��ݿγ̱�ţ��γ�����ģ����ѯ
        public int SearchCourse(int iRight, string strUserNo, string strCourseNo, string strCourseName,string strClassName, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();

            string strSql = "";
            if (iRight == 1)
            {

                strSql = "select CourseNo �γ̱��,CourseName �γ�����,className �༶����,classNo �༶���,Points ѧ��,a.Remark ��ע from course a,class b ,class_course c where a.type =1 and b.type =1 and c.type =1 and a.courseid = c.courseid and b.classid = c.classid and CourseNo like '%" + strCourseNo + "%' escape '\\' ";
                strSql += " and CourseName like '%" + strCourseName + "%' escape '\\' and  ClassName like '%" + strClassName + "%' escape '\\'";
                ///strSql = "select StuNo ѧ�����,stuName ѧ������,ClassName �༶����,class.classNo �༶���,CourseName �γ�����,courseNo �γ̱��,Score �÷� from student,score,course,class where course.CourseNo like+ '%" + strCourseNo + "%' escape '\\'" +" and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
                ///strSql = "select StuNo ѧ�����,stuName ѧ������,ClassName �༶����,class.classNo �༶���,CourseName �γ�����,CourseNo �γ̱��,Score �÷� from Student,Score,Course,Class where Course.CourseName like '%" + strCourseName + "%'escape '\\'" + " and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
                //strSql = "select StuNo ѧ�����,stuName ѧ������,ClassName �༶����,class.classNo �༶���,CourseName �γ�����,courseNo �γ̱��,Score �÷� from student,score,course,class where course.CourseName like+ '%" + strCourseName + "%' escape '\\'" + " and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
                ///strSql = "select StuNo ѧ�����,stuName ѧ������,ClassName �༶����,class.classNo �༶���,CourseName �γ�����,courseNo �γ̱��,Score �÷� from student,score,course,class where class.ClassName like+ '%" + strClassName + "%' escape '\\'" + " and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";

                //strSql = "select CourseNo �γ̱��,CourseName �γ�����,className �༶����,classNo �༶���,Points ѧ��,a.Remark ��ע from course a,class b ,class_course c where a.type =1 and b.type =1 and c.type =1 and a.courseid = c.courseid and b.classid = c.classid and CourseNo like '%" + strCourseNo + "%' escape '\\' ";
                //strSql += " and CourseName like '%" + strCourseName + "%' escape '\\' and  ClassName like '%" + strClassName + "%' escape '\\'";
            }

            if (iRight == 2)
            {


                strSql = "select CourseNo �γ̱��,CourseName �γ�����,className �༶����,f.teaNo ��ʦ��� ,f.teaName ��ʦ����, classNo �༶���,Points ѧ��,a.Remark ��ע from course a,class b,class_course c,class_teacher d,teacher f,teacher_course e where a.courseid = c.courseid and a.courseid = e.courseid and b.classid = c.classid and b.classid = d.classid and f.teaid = e.teaid and CourseNo like '%" + strCourseNo + "%' escape '\\' ";
                strSql += "and CourseName like '%" + strCourseName + "%' escape '\\' and ClassName like '%" + strClassName + "%' escape '\\'and f.teaNo ='" + strUserNo + "'";
                strSql += "and b.classno in (select class.classNo from class,class_teacher,teacher where teacher.teaNo ='" + strUserNo + "' and class.classid = class_teacher.classid and teacher.teaid = class_teacher.teaid )";


                ///strSql = "select StuNo ѧ�����,stuName ѧ������,ClassName �༶����,class.classNo �༶���,CourseName �γ�����,courseNo �γ̱��,Score �÷� from student,score,course,class where course.CourseNo like+ '%" + strCourseNo + "%' escape '\\'" + " and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
                ///strSql = "select StuNo ѧ�����,stuName ѧ������,ClassName �༶����,class.classNo �༶���,CourseName �γ�����,courseNo �γ̱��,Score �÷� from student,score,course,class where course.CourseName like+ '%" + strCourseName + "%' escape '\\'" + " and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
                ///strSql = "select StuNo ѧ�����,stuName ѧ������,ClassName �༶����,class.classNo �༶���,CourseName �γ�����,courseNo �γ̱��,Score �÷� from student,score,course,class where class.ClassName like+ '%" + strClassName + "%' escape '\\'" + " and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
                
                //strSql = "select CourseNo �γ̱��,CourseName �γ�����,className �༶����,f.teaNo ��ʦ��� ,f.teaName ��ʦ����, classNo �༶���,Points ѧ��,a.Remark ��ע from course a,class b,class_course c,class_teacher d,teacher f,teacher_course e where a.courseid = c.courseid and a.courseid = e.courseid and b.classid = c.classid and b.classid = d.classid and f.teaid = e.teaid and CourseNo like '%" + strCourseNo + "%' escape '\\' ";
                //strSql += "and CourseName like '%" + strCourseName + "%' escape '\\' and ClassName like '%" + strClassName + "%' escape '\\'and f.teaNo ='"+strUserNo+"'";
                //strSql += "and b.classno in (select class.classNo from class,class_teacher,teacher where teacher.teaNo ='" + strUserNo + "' and class.classid = class_teacher.classid and teacher.teaid = class_teacher.teaid )";
            }

            if (iRight == 3)
            {

                strSql = "select CourseNo �γ̱��,CourseName �γ�����,Points ѧ��,Remark ��ע from Course where Type=1 and CourseNo like '%" + strCourseNo + "%' escape '\\' and CourseName like '%" + strCourseName + "%' escape '\\' ";
                strSql += "and CourseId in (select CourseId from Class_Course where ClassId in (select ClassId from Student where StuNo ='" + strUserNo + "'))";

                ///strSql = "select StuNo ѧ�����,stuName ѧ������,ClassName �༶����,class.classNo �༶���,CourseName �γ�����,courseNo �γ̱��,Score �÷� from student,score,course,class where course.CourseNo like+ '%" + strCourseNo + "%' escape '\\'" + " and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
                ///strSql = "select StuNo ѧ�����,stuName ѧ������,ClassName �༶����,class.classNo �༶���,CourseName �γ�����,courseNo �γ̱��,Score �÷� from student,score,course,class where course.CourseName like+ '%" + strCourseName + "%' escape '\\'" + " and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
                ///strSql = "select StuNo ѧ�����,stuName ѧ������,ClassName �༶����,class.classNo �༶���,CourseName �γ�����,courseNo �γ̱��,Score �÷� from student,score,course,class where class.ClassName like+ '%" + strClassName + "%' escape '\\'" + " and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
                //strSql = "select CourseNo �γ̱��,CourseName �γ�����,Points ѧ��,Remark ��ע from Course where Type=1 and CourseNo like '%" + strCourseNo + "%' escape '\\' and CourseName like '%" + strCourseName + "%' escape '\\' ";
                //strSql += "and CourseId in (select CourseId from Class_Course where ClassId in (select ClassId from Student where StuNo ='" + strUserNo + "'))";
            }


            sqlCom.CommandText = strSql;
             
            //sqlCom.SelectCommand = sqlCon;
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCom);
            sqlDa.SelectCommand = sqlCom;

            try
            {
                sqlCom.Connection = sqlCon;
                //sqlCom.Connection = sqlCom;
                sqlDa.Fill(objDataTable);
                //sqlDa.Fill(objDataTable);
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


        public int SearchCourse3(out DataTable objDataTable, out string strErr)
        {
            objDataTable = new DataTable();
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "select CourseId,CourseName from Course where Type=1";
            sqlCom.Connection = sqlCon;
            SqlDataAdapter sqlDa = new SqlDataAdapter();
           // sqlDa.SelectCommand = sqlCon;
            sqlDa.SelectCommand = sqlCom;
                //(sqlCom);

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
