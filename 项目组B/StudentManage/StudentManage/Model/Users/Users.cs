using System;
using System.Collections.Generic;
using System.Text;

/*
Model.User��Model�����ռ��µ�User��.
1.�޸��û�����ķ�����
 public int ModifyUser(string  UserName , Model.Users.Users objUsers, out string strErr)
string  UserName�Ƕ�������û����ı����������û��������û���Model.Users.Users objUsers ��ģ���࣬�õ��û��������룬out string strErr ���岶�����ı�����������ֵΪ1���޸ĳɹ�������ֵΪ0 ������������󸳸�strErr 

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
