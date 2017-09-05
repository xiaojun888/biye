using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Teacher_Course
{
    public class Teacher_Course
    {
        private int _Tea_CoId;
        private int _TeaId;
        private int _CourseId;
        private string _Remark;
        private int _Type;

        public int Tea_CoId
        {
            get
            {
                return _Tea_CoId;
            }
            set
            {
                _Tea_CoId = value;
            }
        }
        public int TeaId
        {
            get
            {
                return _TeaId;
            }
            set
            {
                _TeaId = value;
            }
        }
        public int CourseId
        {
            get
            {
                return _CourseId;
            }
            set
            {
                _CourseId = value;
            }
        }
        public string Remark
        {
            get
            {
                return _Remark;
            }
            set
            {
                _Remark = value;
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
