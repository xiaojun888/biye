using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Teacher
{
    public class Teacher
    {
        private int _TeaId;
        private string _TeaNo;
        private string _TeaName;
        private string _Sex;
        private int _Age;
        private string _Degree;
        private string _Rank;
        private string _TeaTel;
        private string _TeaAddress;
        private string _Remark;
        public int TeaId
        {
            get { return _TeaId; ;}
            set { _TeaId = value; }
        }
        public string TeaNo
        {
            get { return _TeaNo; }
            set { _TeaNo = value; }
        }
        public string TeaName
        {
            get { return _TeaName; }
            set { _TeaName = value; }
        }
        public string Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }
        public int  Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public string Degree
        {
            get { return _Degree; }
            set { _Degree = value; }
        }
        public string Rank
        {
            get { return _Rank; }
            set { _Rank = value; }
        }
        public string TeaTel
        {
            get { return _TeaTel; }
            set { _TeaTel = value; }
        }
        public string TeaAddress
        {
            get { return _TeaAddress; }
            set { _TeaAddress = value; }
        }
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }
    }
}
