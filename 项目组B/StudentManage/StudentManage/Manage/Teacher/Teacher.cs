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
        //public int AddTea(Model.Teacher.Teacher objTea, out string strErr)为添加的方法 
       //增加教师信息,int iRent为1添加信息成功,同时添加用户成功,为0则返回错误提示,并将错误赋给strErr
        public int AddTea(Model.Teacher.Teacher objTea, out string strErr)                                                      //增加教师信息同时增加账号
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
        //删除教师信息的方法:public int DelTea(string strTeaNo, out string strErr)   
       //删除教师和账号,string strTeaNo是定义接收教师编号的变量, out string strErr定义捕获错误的变量，当返回值为1时，删除成功，当返回值为0时，出错，则将错误赋给strErr。
      // 删除教师信息同时删除账号信息同时删除教师课程记录，教师班级记录
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

        //修改教师信息的方法,public int ModifyTea(string strTeaNo, Model.Teacher.Teacher objTea, out string strErr)     
       //int iTeaId是传入的教师ID， string strOld是传入的旧的教师编号，
      //Model.teacher.teacher objTea是模型类， out string strErr定义捕获错误的变量
     //int 为1则修改成功，同时修改用户成功，模型类存储教师的相关信息，为0则返回错误提示，将错误赋给strErr。       
        public int ModifyTea(string strTeaNo, Model.Teacher.Teacher objTea, out string strErr)                         //修改教师信息同时修改账号信息
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

        //查询教师信息方法：
       //public int SearchTea (out DataTable objDataTable ,out string strErr) 
      //out DataTable objDataTable定义了一个表
     //out string strErr 定义捕获错误的变量，当返回值为1则查询成功，定义的表显示查询结果，返回值为0 ，则出错，将错误赋给strErr。
  
        public int SearchTea(out DataTable objDataTable, out string strErr)                                                     
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "select teano 教师编号,teaname 教师姓名,sex 性别,age 年龄,degree 学历,rank 职称,teatel 联系方式,teaaddress 住址,remark 备注 from teacher where type=1";
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

                           
          //根据教师编号、教师姓名进行查询
         //string strTeaNo定义接收教师编号的变量
        //string strTeaName定义接收教师姓名的变量
       //out DataTable objDataTable定义了一个表
      //out string strErr 定义捕获错误的变量，当返回值为1时，根据传入的教师编号和教师姓名查询成功，将查询结果给表，返回值为0，则将错误赋给strErr                                             
        public int SearchTea(string strTeaNo, string strTeaName, out DataTable objDataTable, out string strErr)                 
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "select teaid 教师ID,teano 教师编号,teaname 教师姓名,sex 性别,age 年龄,degree 学历,rank 职称,teatel 联系方式,teaaddress 住址,remark 备注 ";
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

        public int StuSearchAllTea(string StuNo, out DataTable objDataTable, out string strErr)                                  //学生查询所有授课教师记录
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "select distinct a.teano 教师编号, a.teaname 教师姓名,a.sex 性别,a.age 年龄,a.degree 学历,a.rank 职称,a.teatel 联系方式,a.teaaddress 住址 ";
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
        public int StuSearchOneTeaNo(string TeaNo, string TeaName, string StuNo, out DataTable objDataTable, out string strErr)   //学生根据教师编号、教师姓名查询授课教师记录
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "select distinct a.teano 教师编号, a.teaname 教师姓名,a.sex 性别,a.age 年龄,a.degree 学历,a.rank 职称,a.teatel 联系方式,a.teaaddress 住址 ";
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
        public int JudgeTeaNo(string TeaNo)                                                                                      //判断教师是否与教师编号重复
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
        public int JudgeTeaNoLikeStuNo(string TeaNo)                                                                                      //判断教师编号是否与学生编号重复
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
