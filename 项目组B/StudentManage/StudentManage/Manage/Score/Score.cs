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
        //输入学生编号、课程编号，将要删除的成绩表里的type值设为0，查询时只显示type为1的记录。

        public int SearchScoreClass(string ClassNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strCom;

            Model.Class.Class objClass = new Model.Class.Class();
            //此处有错误
            //class.classNo
            //strCom = "select StuNo 学生编号,stuName 学生姓名,className 班级名称,class.classNo 班级编号,CourseName 课程名称,courseNo 课程编号,Score 得分 from student,score,course,class where course.CourseNo like '%";
            //strCom += ClassNo.ToString() + "%'escape '\\' and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
            //strCom= "select StuNo 学生编号,stuName 学生姓名,ClassName 班级名称,class.classNo 班级编号,CourseName 课程名称,courseNo 课程编号,Score 得分 from student,score,course,class where course.CourseNo like";
            //strCom+=  ClassNo.ToString()+"and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
            //strCom = "select StuNo 学生编号,stuName 学生姓名,ClassName 班级名称,class.classNo 班级编号,CourseName 课程名称,courseNo 课程编号,Score 得分 from student,score,course,class where class.ClassName like+ '%" +  + "%' escape '\\'" + " and score.courseId = course.courseId and score.stuId = student.stuId and student.classId = class.classId and score.Type = 1";
            strCom = "select StuNo 学生编号,stuName 学生姓名,classname 班级名称,class.classNo 班级编号,CourseName 课程名称,courseNo 课程编号,Score 得分 from student,score,course,class where class.classNo like '%";
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
        }//管理员按班级查询班级内所有学生的成绩。

        public int SearchScoreStudent(string StuNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            Model.Student.Student objStudent = new Model.Student.Student();

            strCom = "select student.stuNo 学生编号,student.stuName 姓名,course.courseNo 课程编号,course.courseName 课程名称,score.score 得分 from student,score,course where student.stuNo like '%";
            strCom += StuNo.ToString() + "%'escape '\\'and score.stuId = student.stuId and  course.courseId = score.courseId and score.Type = 1 and student.Type = 1";


            //strCom = "select student.stuNo 学生编号,student.stuName 姓名,course.courseNo 课程编号,course.courseName 课程名称,score.score 得分 from student,score,course where student.StuName like '%";
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
        }//管理员按学生编号查询该学生的各科成绩。

        public int SearchScoreCourse(string CourseNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            Model.Student.Student objStudent = new Model.Student.Student();

            strCom = "select distinct student.stuNo 学生编号,student.stuName 姓名,course.courseNo 课程编号,course.courseName 课程名称,score.score 得分 from student,score,course where course.courseNo like'%";
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
        }//管理员按课程查询该课程学生成绩

        public int SearchScoreTeaByAdmin(string strTeaNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            Model.Teacher.Teacher objTeacher = new Model.Teacher.Teacher();

            //strCom = strCom = "select distinct teacher.teaNo as 教师编号,teacher.teaName as 教师名称,student.stuNo as 学生编号,course.courseName as 课程名称, Course.Points as 得分,student.stuName as 学生姓名 from student,score,teacher_course,teacher,course where teacher.TeaNo like '%" + strTeaNo + "%'escape '\\' and Score.StuId = Student.stuId and  Course.CourseId = Score.CourseId and Course.CourseId=Teacher_Course.CourseId and Student.Type = 1 and Teacher.Type = 1 ";
            strCom = "select distinct teacher.teaNo as 教师编号,teacher.teaName as 教师名称,student.stuNo as 学生编号,course.courseName as 课程名称, score.Score as 得分,student.stuName as 学生姓名 from student,score,teacher_course,teacher,course where teacher.teaNo like '%";
            strCom += strTeaNo + "%'escape '\\' and score.stuId = student.stuId and  course.courseId = score.courseId and course.courseid=teacher_course.courseid and teacher.teaId = teacher_Course.teaId and score.Type = 1 and student.Type = 1 and teacher.Type = 1 ";

            //strCom = "select student.stuNo 学生编号,student.stuName 姓名,course.courseNo 课程编号,course.courseName 课程名称,score.score 得分 from student,score,course where student.StuName like '%";
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


        }//管理员按教师编号查询所有学生的成绩。

        public int SearchScore(out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            Model.Score.Score objScore = new Model.Score.Score();
            strCom = "select distinct student.stuNo 学号,student.stuName 学生姓名,course.courseName 课程名称,course.courseno 课程编号, score.Score 得分 from student,score,course where score.stuId = student.stuId and  course.courseId = score.courseId  and score.Type = 1 and student.Type = 1 and course.Type =1";

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
        }//管理员登陆后，查询所有成绩表里的记录。


        public int SearchScoreCourseTea(string CourseNo, string UserNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            strCom = "select distinct teacher.teaNo 教师编号,teacher.teaName 教师名称,course.courseNo 课程编号,course.courseName 课程名称,student.stuNo 学生编号,student.stuName 学生名称,score.score 成绩 from course,teacher,score,student,teacher_course where course.courseNo like '%";
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
        } // 教师登陆，按课程查询所教学生成绩
        public int SearchScoreClassTea(string ClassNo, string UserNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            strCom = "select distinct teacher.teaName 教师名称,course.courseName 课程名称,student.stuNo 学生编号,student.stuName 学生名称,class.className 班级名称,class.classNo 班级编号,score.score 成绩 from course,teacher,score,student,teacher_course,class,class_Teacher where class.classNo  like '%";
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
        } //教师按班级查询所带学生成绩

        public int SearchScoreStuTea(string StuNo, string UserNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            strCom = "select distinct teacher.teaName 教师名称,course.courseName 课程名称,student.stuNo 学生编号,student.stuName 学生名称,class.className 班级名称,class.classNo 班级编号,score.score 成绩 from course,teacher,score,student,teacher_course,class,class_Teacher where student.stuNo  like '%";
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
        } //教师按查询单个学生成绩

        public int SearchScoreTea(string userNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            strCom = "select distinct b.teaNo 教师编号,b.teaName 教师名称,c.courseNo 课程编号,c.courseName 课程名称,a.stuNo 学生编号,a.stuName 学生名称,e.className 班级名称,e.classNo 班级编号, d.score 成绩 from student a,teacher b,course c,score d,class e,teacher_course f where a.stuId = d.stuid and d.courseid = c.courseid and c.courseid = f.courseId and b.teaid = f.teaid and c.courseid in (select distinct courseId from teacher,teacher_course where teacher.teaid = teacher_course.teaid and teaNo = '";
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
        }  //教师登陆后，数据表里显示该教师所教的所有学生的成绩。


        public int SearchScoreCourseStu(string CourseNo, string UserNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            strCom = "select  stuNo 学生编号,stuName 学生名称,course.courseNo 课程编号,courseName 课程名称,Class.className 班级名称,score 得分 from student,class,score,course,class_course where class.classid =(select class.classid from class,student where stuNo = '";
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
        } //学生按课程查询个人成绩。

        public int SearchScoreStuStu(string StuNo, string UserNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            strCom = "select distinct stuNo 学生编号,stuName 学生名称,courseName 课程名称,Class.className 班级名称,score 得分 from student,class,score,course,class_course where class.classid =(select class.classid from class,student where stuNo = '";
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
        } //学生按学号查询本班个人成绩

        public int SearchScoreTeaStu(string strTeaNo, string UserNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            objDataTable = new DataTable();
            Model.Teacher.Teacher objTeacher = new Model.Teacher.Teacher();

            //strCom = "select distinct teacher.teaNo as 教师编号,teacher.teaName as 教师名称,student.stuNo as 学生编号,course.courseName as 课程名称, Course.Points as 得分,student.stuName as 学生姓名 from student,score,teacher_course,teacher,course where teacher.TeaNo like '%" + strTeaNo + "%'escape '\\' and Score.StuId = Student.stuId and  Course.CourseId = Score.CourseId and Course.CourseId=Teacher_Course.CourseId and Student.Type = 1 and Teacher.Type = 1 ";
            strCom = "select distinct teacher.teaNo  教师编号,teacher.teaName  教师名称,student.stuNo  学生编号,student.stuName  学生姓名,course.courseName  课程名称, score.Score  得分 from student,score,teacher_course,teacher,course where teacher.teaNo like '%";
            strCom += strTeaNo + "%'escape '\\'and student.stuNo ='" + UserNo + "'and score.stuId = student.stuId and  course.courseId = score.courseId and teacher.teaId = teacher_Course.teaId and score.Type = 1 and student.Type = 1 and teacher.Type = 1 and teacher_course.courseid = course.courseid";
            //strCom = "select distinct teacher.teaNo  教师编号,teacher.teaName  教师名称,student.stuNo  学生编号,student.stuName  学生姓名,course.courseName  课程名称,Course.Points  得分 from student,score,teacher_course,teacher,course where teacher.teaNo like '%";
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


        }//学生按教师编号查询全班学生成绩
        public int SearchScoreStu(string userNo, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strCom;
            Model.Score.Score objScore = new Model.Score.Score();
            strCom = "select  stuNo 学生编号,stuName 学生名称,courseName 课程名称,Class.className 班级名称,score 得分 from student,class,score,course,class_course where class.classid =(select class.classid from class,student where stuNo = '";
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
        }//学生登陆后，绑定表里显示的数据


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
        //通过查询插入的成绩是否存在来判断能不能插入当前成绩。返回查询结果：0或非0　
    }
}
