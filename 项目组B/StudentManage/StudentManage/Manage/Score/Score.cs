using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Manage.Score
{
    public class Score
    {
        SqlConnection sqlCon;

        public Score(string strSqlConnection)
        {
            sqlCon = new SqlConnection(strSqlConnection);
        }

        public int AddScore(Model.Score.Score objScore, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = sqlCon;
            string strSql = "insert into score(CourseId,StuId,Score,Type)";
            strSql += "values  (" + objScore.CourseId.ToString() + "," + objScore.StuId.ToString() + "," + objScore.score.ToString() + ",1)";
            sqlCom.CommandText = strSql;
            try
            {
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
                iReturn = 1;
            }
            catch (Exception exErr)
            {
                strErr = exErr.ToString();
                iReturn = 0;
            }
            finally
            {
                sqlCon.Close();
                sqlCom.Dispose();
            }
            return iReturn;

        }

        public int ModifyScore(Model.Score.Score objScore, out string strErr)
        {

            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = sqlCon;
            string strSql = "update score set score = " + objScore.score.ToString();
            strSql += "where CourseId = " + objScore.CourseId.ToString() + "and StuId = " + objScore.StuId.ToString();
            sqlCom.CommandText = strSql;

            try
            {
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
                iReturn = 1;
            }
            catch (Exception exErr)
            {
                strErr = exErr.ToString();
                iReturn = 0;
            }
            finally
            {
                sqlCon.Close();
                sqlCom.Dispose();
            }
            return iReturn;

        }

        public int DelScore(string stuNo, string courseNo, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = sqlCon;
            string strSql = "update score set type =0 where stuId in (select stuId from student where stuNo = '" + stuNo + "') and courseId =(select courseId from course where courseno ='" + courseNo + "')";
            sqlCom.CommandText = strSql;

            try
            {
                sqlCon.Open();
                sqlCom.ExecuteNonQuery();
                iReturn = 1;
            }
            catch (Exception exErr)
            {
                strErr = exErr.ToString();
                iReturn = 0;
            }
            finally
            {
                sqlCon.Close();
                sqlCom.Dispose();
            }
            return iReturn;
        }
        //����ѧ����š��γ̱�ţ���Ҫɾ���ĳɼ������typeֵ��Ϊ0����ѯʱֻ��ʾtypeΪ1�ļ�¼��

        public int SearchScoreClass(string ClassNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strCom;

            Model.Class.Class objClass = new Model.Class.Class();
            //�˴��д���
            //class.classNo
            //strCom = "select StuNo ѧ�����,stuName ѧ������,className �༶����,class.classNo �༶���,CourseName �γ�����,courseNo �γ̱��,Score �÷� from student,score,course,class where course.CourseNo like '%";
            //strCom += ClassNo.ToString() + "%'escape '\\' and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
            //strCom= "select StuNo ѧ�����,stuName ѧ������,ClassName �༶����,class.classNo �༶���,CourseName �γ�����,courseNo �γ̱��,Score �÷� from student,score,course,class where course.CourseNo like";
            //strCom+=  ClassNo.ToString()+"and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
            //strCom = "select StuNo ѧ�����,stuName ѧ������,ClassName �༶����,class.classNo �༶���,CourseName �γ�����,courseNo �γ̱��,Score �÷� from student,score,course,class where class.ClassName like+ '%" +  + "%' escape '\\'" + " and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
            strCom = "select StuNo ѧ�����,stuName ѧ������,classname �༶����,class.classNo �༶���,CourseName �γ�����,courseNo �γ̱��,Score �÷� from student,score,course,class where class.classNo like '%";
            strCom += ClassNo.ToString() + "%'escape '\\' and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";

            sqlCom.CommandText = strCom;
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
        }//����Ա���༶��ѯ�༶������ѧ���ĳɼ���

        public int SearchScoreStudent(string StuNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            Model.Student.Student objStudent = new Model.Student.Student();

            strCom = "select student.stuNo ѧ�����,student.stuName ����,course.courseNo �γ̱��,course.courseName �γ�����,score.score �÷� from student,score,course where student.stuNo like '%";
            strCom += StuNo.ToString() + "%'escape '\\'and score.stuId = student.stuId and  course.courseId = score.courseId and score.Type = 1 and student.Type = 1";


            //strCom = "select student.stuNo ѧ�����,student.stuName ����,course.courseNo �γ̱��,course.courseName �γ�����,score.score �÷� from student,score,course where student.StuName like '%";
            //strCom += StuName.ToString() + "%'escape '\\'and score.stuId = student.stuId and  course.courseId = score.courseId and score.Type = 1 and student.Type = 1";
            sqlCom.CommandText = strCom;
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
        }//����Ա��ѧ����Ų�ѯ��ѧ���ĸ��Ƴɼ���

        public int SearchScoreCourse(string CourseNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            Model.Student.Student objStudent = new Model.Student.Student();

            strCom = "select distinct student.stuNo ѧ�����,student.stuName ����,course.courseNo �γ̱��,course.courseName �γ�����,score.score �÷� from student,score,course where course.courseNo like'%";
            strCom += CourseNo.ToString() + "%' and score.stuId = student.stuId and  course.courseId = score.courseId and score.Type = 1 and student.Type = 1";

            sqlCom.CommandText = strCom;
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
        }//����Ա���γ̲�ѯ�ÿγ�ѧ���ɼ�

        public int SearchScoreTeaByAdmin(string strTeaNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            Model.Teacher.Teacher objTeacher = new Model.Teacher.Teacher();

            //strCom = strCom = "select distinct teacher.teaNo as ��ʦ���,teacher.teaName as ��ʦ����,student.stuNo as ѧ�����,course.courseName as �γ�����, Course.Points as �÷�,student.stuName as ѧ������ from student,score,teacher_course,teacher,course where teacher.TeaNo like '%" + strTeaNo + "%'escape '\\' and Score.StuId = Student.stuId and  Course.CourseId = Score.CourseId and Course.CourseId=Teacher_Course.CourseId and Student.Type = 1 and Teacher.Type = 1 ";
            strCom = "select distinct teacher.teaNo as ��ʦ���,teacher.teaName as ��ʦ����,student.stuNo as ѧ�����,course.courseName as �γ�����, score.Score as �÷�,student.stuName as ѧ������ from student,score,teacher_course,teacher,course where teacher.teaNo like '%";
            strCom += strTeaNo + "%'escape '\\' and score.stuId = student.stuId and  course.courseId = score.courseId and course.courseid=teacher_course.courseid and teacher.teaId = teacher_Course.teaId and score.Type = 1 and student.Type = 1 and teacher.Type = 1 ";

            //strCom = "select student.stuNo ѧ�����,student.stuName ����,course.courseNo �γ̱��,course.courseName �γ�����,score.score �÷� from student,score,course where student.StuName like '%";
            //strCom += StuName.ToString() + "%'escape '\\'and score.stuId = student.stuId and  course.courseId = score.courseId and score.Type = 1 and student.Type = 1";

            sqlCom.CommandText = strCom;
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


        }//����Ա����ʦ��Ų�ѯ����ѧ���ĳɼ���

        public int SearchScore(out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            Model.Score.Score objScore = new Model.Score.Score();
            strCom = "select distinct student.stuNo ѧ��,student.stuName ѧ������,course.courseName �γ�����,course.courseno �γ̱��, score.Score �÷� from student,score,course where score.stuId = student.stuId and  course.courseId = score.courseId  and score.Type = 1 and student.Type = 1 and course.Type =1";

            sqlCom.CommandText = strCom;
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
        }//����Ա��½�󣬲�ѯ���гɼ�����ļ�¼��


        public int SearchScoreCourseTea(string CourseNo, string UserNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            strCom = "select distinct teacher.teaNo ��ʦ���,teacher.teaName ��ʦ����,course.courseNo �γ̱��,course.courseName �γ�����,student.stuNo ѧ�����,student.stuName ѧ������,score.score �ɼ� from course,teacher,score,student,teacher_course where course.courseNo like '%";
            strCom += CourseNo + "%'escape '\\'and teacher.teaNo = '" + UserNo + "'and score.stuId = student.stuId and  course.courseId = score.courseId and score.Type = 1 and student.Type = 1and course.courseid in (select courseId from teacher,teacher_course where teacher.teaid = teacher_course.teaid and teaNo = '" + UserNo + "')";

            sqlCom.CommandText = strCom;
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
        } // ��ʦ��½�����γ̲�ѯ����ѧ���ɼ�
        public int SearchScoreClassTea(string ClassNo, string UserNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            strCom = "select distinct teacher.teaName ��ʦ����,course.courseName �γ�����,student.stuNo ѧ�����,student.stuName ѧ������,class.className �༶����,class.classNo �༶���,score.score �ɼ� from course,teacher,score,student,teacher_course,class,class_Teacher where class.classNo  like '%";
            strCom += ClassNo + "%'escape '\\'and teacher.teaNo  ='" + UserNo + "'and score.stuId = student.stuId and class.classid = class_Teacher.classId and course.courseId = score.courseId and score.Type = 1 and student.Type = 1 and class.classid in (select distinct classId from teacher,class_teacher where teacher.teaId = class_teacher.teaId and teaNO = '" + UserNo + "') and course.courseid in (select courseId from teacher,teacher_course where teacher.teaid = teacher_course.teaid and teaNo = '" + UserNo + "')";

            sqlCom.CommandText = strCom;
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
        } //��ʦ���༶��ѯ����ѧ���ɼ�

        public int SearchScoreStuTea(string StuNo, string UserNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            strCom = "select distinct teacher.teaName ��ʦ����,course.courseName �γ�����,student.stuNo ѧ�����,student.stuName ѧ������,class.className �༶����,class.classNo �༶���,score.score �ɼ� from course,teacher,score,student,teacher_course,class,class_Teacher where student.stuNo  like '%";
            strCom += StuNo + "%'escape '\\'and teacher.teaNo  = '" + UserNo + "'and score.stuId = student.stuId and class.classid = class_Teacher.classId and class_Teacher.teaId = teacher.teaId and course.courseId = score.courseId and score.Type = 1 and student.Type = 1and class.classid in (select distinct classId from teacher,class_teacher where teacher.teaId = class_teacher.teaId and teaNO = '1') and course.courseid in (select courseId from teacher,teacher_course where teacher.teaid = teacher_course.teaid and teaNo = '" + UserNo + "')";

            sqlCom.CommandText = strCom;
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
        } //��ʦ����ѯ����ѧ���ɼ�

        public int SearchScoreTea(string userNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            strCom = "select distinct b.teaNo ��ʦ���,b.teaName ��ʦ����,c.courseNo �γ̱��,c.courseName �γ�����,a.stuNo ѧ�����,a.stuName ѧ������,e.className �༶����,e.classNo �༶���, d.score �ɼ� from student a,teacher b,course c,score d,class e,teacher_course f where a.stuId = d.stuid and d.courseid = c.courseid and c.courseid = f.courseId and b.teaid = f.teaid and c.courseid in (select distinct courseId from teacher,teacher_course where teacher.teaid = teacher_course.teaid and teaNo = '";
            strCom += userNo + "') and e.classid in (select distinct classId from teacher,class_teacher where teacher.teaId = class_teacher.teaId and teaNO = '" + userNo + "')  and  teaNo = '" + userNo + "'and d.type = 1 and a.type =1 and b.type = 1";

            sqlCom.CommandText = strCom;
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
        }  //��ʦ��½�����ݱ�����ʾ�ý�ʦ���̵�����ѧ���ĳɼ���


        public int SearchScoreCourseStu(string CourseNo, string UserNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            strCom = "select  stuNo ѧ�����,stuName ѧ������,course.courseNo �γ̱��,courseName �γ�����,Class.className �༶����,score �÷� from student,class,score,course,class_course where class.classid =(select class.classid from class,student where stuNo = '";
            strCom += UserNo + "'and student.classId=class.classId )and score.stuId = student.stuId  and course.courseId = score.courseId and class.classid =class_course.classId and class_course.courseid = course.courseId and score.Type = 1 and student.Type = 1 and  course.Type =1 and course.courseno like '%" + CourseNo + "%'escape '\\'";

            sqlCom.CommandText = strCom;
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
        } //ѧ�����γ̲�ѯ���˳ɼ���

        public int SearchScoreStuStu(string StuNo, string UserNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            strCom = "select distinct stuNo ѧ�����,stuName ѧ������,courseName �γ�����,Class.className �༶����,score �÷� from student,class,score,course,class_course where class.classid =(select class.classid from class,student where stuNo = '";
            strCom += UserNo + "'and student.classId=class.classId )and score.stuId = student.stuId and student.stuNo  like '%";
            strCom += StuNo + "%'escape '\\' and course.courseId = score.courseId and class.classid =class_course.classId and class_course.courseid = course.courseId and score.Type = 1 and student.Type = 1 and course.Type =1";

            sqlCom.CommandText = strCom;
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
        } //ѧ����ѧ�Ų�ѯ������˳ɼ�

        public int SearchScoreTeaStu(string strTeaNo, string UserNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            Model.Teacher.Teacher objTeacher = new Model.Teacher.Teacher();

            //strCom = "select distinct teacher.teaNo as ��ʦ���,teacher.teaName as ��ʦ����,student.stuNo as ѧ�����,course.courseName as �γ�����, Course.Points as �÷�,student.stuName as ѧ������ from student,score,teacher_course,teacher,course where teacher.TeaNo like '%" + strTeaNo + "%'escape '\\' and Score.StuId = Student.stuId and  Course.CourseId = Score.CourseId and Course.CourseId=Teacher_Course.CourseId and Student.Type = 1 and Teacher.Type = 1 ";
            strCom = "select distinct teacher.teaNo  ��ʦ���,teacher.teaName  ��ʦ����,student.stuNo  ѧ�����,student.stuName  ѧ������,course.courseName  �γ�����, score.Score  �÷� from student,score,teacher_course,teacher,course where teacher.teaNo like '%";
            strCom += strTeaNo + "%'escape '\\'and student.stuNo ='" + UserNo + "'and score.stuId = student.stuId and  course.courseId = score.courseId and teacher.teaId = teacher_Course.teaId and score.Type = 1 and student.Type = 1 and teacher.Type = 1 and teacher_course.courseid = course.courseid";
            //strCom = "select distinct teacher.teaNo  ��ʦ���,teacher.teaName  ��ʦ����,student.stuNo  ѧ�����,student.stuName  ѧ������,course.courseName  �γ�����,Course.Points  �÷� from student,score,teacher_course,teacher,course where teacher.teaNo like '%";
            //strCom += strTeaNo + "%'escape '\\'and student.stuNo ='" + UserNo + "'and score.stuId = student.stuId and  course.courseId = score.courseId and teacher.teaId = teacher_Course.teaId and score.Type = 1 and student.Type = 1 and teacher.Type = 1 and teacher_course.courseid = course.courseid";

            sqlCom.CommandText = strCom;
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


        }//ѧ������ʦ��Ų�ѯȫ��ѧ���ɼ�
        public int SearchScoreStu(string userNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            Model.Score.Score objScore = new Model.Score.Score();
            strCom = "select  stuNo ѧ�����,stuName ѧ������,courseName �γ�����,Class.className �༶����,score �÷� from student,class,score,course,class_course where class.classid =(select class.classid from class,student where stuNo = '";
            strCom += userNo + "'and student.classId=class.classId )and score.stuId = student.stuId  and course.courseId = score.courseId and class.classid =class_course.classId and class_course.courseid = course.courseId and score.Type = 1 and student.Type = 1 and course.Type =1";
            sqlCom.CommandText = strCom;
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
        }//ѧ����½�󣬰󶨱�����ʾ������


        public int Judge(Model.Student.Student objStuId, Model.Course.Course objCourseId)
        {

            string strErr = "";
            Model.Score.Score objScore = new Model.Score.Score();
            DataSet ds = new DataSet();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            string strSql = "select Score from score where stuid='" + objStuId.StuId.ToString() + "'and CourseId='" + objCourseId.CourseId + "'and type =1";
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

            if (ds.Tables[0].Rows.Count != 0)
            {
                return 1;
            }

            else
            {
                return 0;
            }

        }
        public int JudgeStu()
        {

            string strErr = "";
            DataSet ds = new DataSet();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            string strSql = "select student.stuid  from student,class where student.classid=class.classid and student.type=1 and class.type=1";
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

            if (ds.Tables[0].Rows.Count != 0)
            {
                return 1;
            }

            else
            {
                return 0;
            }

        }
        public int JudgeCourse()
        {

            string strErr = "";
            DataSet ds = new DataSet();
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManager"].ConnectionString;
            string strSql = "select courseid from course where type =1";
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

            if (ds.Tables[0].Rows.Count != 0)
            {
                return 1;
            }

            else
            {
                return 0;
            }

        }
        //ͨ����ѯ����ĳɼ��Ƿ�������ж��ܲ��ܲ��뵱ǰ�ɼ������ز�ѯ�����0���0��
    }
}
