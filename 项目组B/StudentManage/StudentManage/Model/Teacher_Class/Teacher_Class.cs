using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Teacher_Class
{
    public class Teacher_Class
    {
        private int _Tec_ClId;
        private int _TeaId;
        private int _ClassId;
        private string _Remark;


        public int Tec_ClId
        {
            get
            {
                return _Tec_ClId;
            }
            set
            {
                _Tec_ClId = value; ;
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
                _TeaId = value; ;
            }
        }
        public int ClassId
        {
            get
            {
                return _ClassId;
            }
            set
            {
                _ClassId = value;
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
    }
}
