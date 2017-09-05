using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Student
{
    public class Student
    {
        private int _StuId;
        private string _StuNo;
        private int _ClassId;
        private string _StuName;
        private string _Sex;
        private DateTime _BirthDate;
        private DateTime _EntranceTime;
        private string _StuTel;
        private string _StuAddress;
        private string _Remark;
        public int StuId
        {
            get { return _StuId; }
            set { _StuId = value; }
        }
        public string StuNo
        {
            get { return _StuNo; }
            set { _StuNo = value; }
        }
        public string StuName
        {
            get { return _StuName; }
            set { _StuName = value; }
        }
        public string Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }
        public DateTime BirthDate
        {
            get { return _BirthDate; }
            set { _BirthDate = value; }
        }
        public int ClassId
        {
            get { return _ClassId; }
            set { _ClassId = value; }
        }

        public DateTime EntranceTime
        {
            get { return _EntranceTime; }
            set { _EntranceTime = value; }
        }
        public string StuTel
        {
            get { return _StuTel; }
            set { _StuTel = value; }
        }
        public string StuAddress
        {
            get { return _StuAddress; }
            set { _StuAddress = value; }
        }
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }
    }
}

