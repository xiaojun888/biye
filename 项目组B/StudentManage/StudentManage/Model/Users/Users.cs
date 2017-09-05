using System;
using System.Collections.Generic;
using System.Text;

/*
Model.User是Model命名空间下的User类.
1.修改用户密码的方法：
 public int ModifyUser(string  UserName , Model.Users.Users objUsers, out string strErr)
string  UserName是定义接收用户名的变量，根据用户名查找用户，Model.Users.Users objUsers 是模型类，得到用户的新密码，out string strErr 定义捕获错误的变量，当返回值为1则修改成功，返回值为0 ，则出错，将错误赋给strErr 

*/

namespace Model.Users
{
    public class Users
    {
        private string _UserNo;
        private string _UserName;
        private string _PassWord;
        private int _Rights;
        private int _Type;
     
        public string UserNo
        {
            get
            {
                return _UserNo;
            }
            set
            {
                _UserNo = value;
            }
        }
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        public string PassWord
        {
            get
            {
                return _PassWord;
            }
            set
            {
                _PassWord = value;
            }
        }
        public int Rights
        {
            get
            {
                return _Rights;
            }
            set
            {
                _Rights = value;
            }
        }
        public int Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }
     
    }
}
