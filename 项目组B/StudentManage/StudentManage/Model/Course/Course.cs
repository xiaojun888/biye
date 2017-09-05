using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Course
{
    public class Course
    {
        private int _CourseId;
        private string _CourseNo;
        private string _CourseName;
        private float _Points;
        private string _ClassName;
        private string _Teacher;
        private string _Remark;
        private int _Type;


        public int CourseId
        {
            get { return _CourseId; }
            set { _CourseId = value; }
        }

        public string CourseNo
        {
            get { return _CourseNo; }
            set { _CourseNo = value; }
        }
        public string CourseName
        {
            get { return _CourseName; }
            set { _CourseName = value; }
        }
        public float Points
        {
            get { return _Points; }
            set { _Points = value; }
        }      

        public string ClassName
        {
            get { return _ClassName; }
            set { _ClassName = value; }
        }


        public string Teacher
        {
            get { return _Teacher; }
            set { _Teacher = value; }
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
