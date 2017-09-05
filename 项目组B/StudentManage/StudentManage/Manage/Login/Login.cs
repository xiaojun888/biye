using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Manage.Login
{
    public class Login
    {
        SqlConnection sqlCon;
        public Login(string strConectionString)
        {
            sqlCon = new SqlConnection(strConectionString);
        }

        //验证登陆
        public int JudgeExist(string UserNo, string PassWord,int Rights, out string strErr)
        {
            strErr = "";
            SqlCommand sqlcom = new SqlCommand();

             string strSql = "";
             if (Rights == 2)
             {
                 strSql = "select * from Users where UserNo='" + UserNo.ToString() + "'and PassWord='" + PassWord.ToString() + "'and Type =1 and Rights=2";
             }
             if (Rights == 3)
             {
                 strSql = "select * from Users where UserNo='" + UserNo.ToString() + "'and PassWord='" + PassWord.ToString() + "'and Type =1 and Rights=3";
             }
            sqlcom.Connection = sqlCon; 
  
            sqlcom.CommandText = strSql;
         
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

        //通过查询修改的帐号存在与否来判断能否修改．如果已存在返回1,不存在返回0      
        public int JudgeUserNo(string UserNo)
        {
            string strErr = "";
            SqlCommand sqlcom = new SqlCommand();
            string strSql = "select UserNo from Users where UserNo='" + UserNo.ToString() + "' and type =1";
            sqlcom.Connection = sqlCon; 
            sqlcom.CommandText = strSql;
          
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


        //管理员查询所有
        public int SearchUser(out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "select UserNo 帐号,UserName 姓名,PassWord 密码,Rights 权限 from Users where Type=1";
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
       
        //管理员删除用户同时删除与用户相关的信息
        public int DelUser(int iRights, string strUserNumble, out string strErr)
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = sqlCon;
            string strSql = "";            
            if (iRights == 2)
            {
                strSql = "update Users set Type=0 where UserNo ='" + strUserNumble.Replace("'", "''") + "' ";
                strSql += "update Teacher set Type=0  where TeaNo ='" + strUserNumble.Replace("'", "''") + "' ";               
                strSql += "update Teacher_Course set type =0 where teaid in ( select teaid from teacher where teaNo ='" + strUserNumble.Replace("'", "''") + "') ";
                strSql += "update Class_Teacher set type =0 where teaid in ( select teaid from teacher where teaNo ='" + strUserNumble.Replace("'", "''") + "')  ";
            }
            if (iRights == 3)
            {
                strSql = "update Users set Type=0 where UserNo ='" + strUserNumble .Replace("'", "''") + "' ";
                strSql += " update Student set Type=0  where StuNo ='" + strUserNumble.Replace("'", "''") + "' ";
                strSql += "update Score set type=0  where stuid in (select stuid from student  where StuNo='" + strUserNumble.Replace("'", "''") + "')";
            }            
            sqlCom.CommandText = strSql;
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
        
        //管理员修改用户信息
        public int ModifyUser(int iRights, string userno,string strUserNo, Model.Users.Users objUsers, out string strErr)
        {
            int iRent = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = sqlCon;
            string strSql = "";
            if (iRights == 2)
            {
                strSql = " update Users set UserNo ='" + userno + "',UserName ='" + objUsers.UserName + "',PassWord='" + objUsers.PassWord + "' where UserNo='" + strUserNo + "' and Type=1 ";
                strSql += " update Teacher set teano='" + userno + "', teaname='" + objUsers.UserName + "' where TeaNo ='" + strUserNo + "'and Type=1  ";

            } 
            if (iRights == 3)
            {
                strSql = " update Users set UserNo ='" + userno + "',UserName ='" + objUsers.UserName + "',PassWord='" + objUsers.PassWord + "' where UserNo='" + strUserNo + "'  and Type=1 ";
                strSql += " update Student set stuno='" + userno + "',stuname='" + objUsers.UserName + "' where StuNo ='" + strUserNo + "' and Type=1  ";
                              
            }

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

        //查询所有教师
        public int SearchUserisTea(out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "select UserNo 帐号, UserName 姓名,PassWord 密码,Rights 权限 from Users where Type=1 and Rights=2";
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

        //查询所有学生
        public int SearchUserisStu(out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "select UserNo 帐号, UserName 姓名,PassWord 密码,Rights 权限 from Users where Type=1 and Rights=3";
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

        //管理员根据帐号或姓名模糊查询
        public int SearchUserBy(string strUserNo,string strUserName, out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "select UserNo 帐号,UserName 姓名,PassWord 密码,Rights 权限 from Users where Type=1 and UserNo like '%" + strUserNo + "%' escape '\\' and UserName like '%" + strUserName + "%' escape '\\'";
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

        //教师和老师登陆查询个人信息
        public int SearchPersonalNews(int iRight,string strUserNo,out DataTable objDataTable, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            objDataTable = new DataTable();
            SqlCommand sqlCom = new SqlCommand();
            string strSql = "";
            if (iRight == 2)
            {
                strSql = "select a.UserNo 帐号,a.UserName 姓名,b.sex 性别,b.age 年龄,b.degree 学历,b.rank 职称,b.teatel 联系方式,b.teaaddress 住址,b.remark 备注, ";
               strSql += "a.PassWord 密码 from Users a,teacher b where a.Type=1 and b.type=1 and a.UserNo=b.TeaNo and b.TeaNo='" + strUserNo + "' ";
            }
            if (iRight == 3)
            {
               strSql = "select a.UserNo 帐号,a.UserName 姓名,b.sex 性别,c.ClassName,b.birthdate 出生日期,b.entrancetime 入学时间,b.stutel 联系方式,b.stuaddress 住址, ";
               strSql += "b.remark 备注,a.PassWord 密码 from users a, student b ,Class c where a.Type=1  and b.type=1 and a.UserNo=b.StuNo and b.classid=c.classid and b.StuNo='" + strUserNo + "'";
              
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

        //用户修改密码       
        public int ChangePWD(int iRights, string struserno,Model.Users.Users objUsers, out string strErr)
        {
            int iReturn = 0;
            strErr = "";
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = sqlCon;
            string strSql = "update Users set PassWord= '" + objUsers.PassWord.ToString() + " ' where UserNo='" + struserno + " ' and Rights=" + iRights.ToString();
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


       

    }
}
