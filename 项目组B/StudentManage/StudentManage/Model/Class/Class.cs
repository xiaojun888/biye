using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Class
{
    public class Class
    {
        private string _ClassNo;
        private string _ClassNumber;
        private string _ClassName;
        private string _Remark;
        private int _Type;
        private string _CourseName;

        public string ClassNo
        {
            get { return _ClassNo; }
            set { _ClassNo = value; }
        }

        public string ClassNumber
        {
            get { return _ClassNumber; }
            set { _ClassNumber = value; }
        }
        public string ClassName
        {
            get { return _ClassName; }
            set { _ClassName = value; }
        }
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }
        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        public string CourseName
        {
            get { return _CourseName; }
            set { _CourseName = value; }
        }
    }
}
