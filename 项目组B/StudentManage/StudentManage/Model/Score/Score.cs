using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Score
{
    public class Score
    {
        private int _ScoreId;
        private int _CourseId;
        private int _StuId;
        private float _score;      
        private string _StuName;
        private int _Type;

        public int ScoreId
        {
            get { return _ScoreId; }
            set { _ScoreId = value; }
        }

        public int StuId
        {
            get { return _StuId; }
            set { _StuId = value; }
        }

        public int CourseId
        {
            get { return _CourseId; }
            set { _CourseId = value; }
        }

        public float score
        {
            get { return _score; }
            set { _score = value; }
        }

        public string StuName
        {
            get { return _StuName; }
            set { _StuName = value; }
        }


        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
    }
}
