using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Class_Course
{
    public class Class_Course
    {
        private int  _ClassId;
        private int  _CourseId;
        private string _Remark;
        private int _Type;


        public int ClassId
        {
            get { return _ClassId; }
            set { _ClassId = value; }
        }
        public int CourseId
        {
            get { return _CourseId; }
            set { _CourseId = value; }
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
    }
}
