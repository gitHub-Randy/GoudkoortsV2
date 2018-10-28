using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class Score
    {
        private int score;

        public Score()
        {
            score = 0;
        }

        public int ScoreNumber
        {
            get { return this.score; }
            set { this.score = value; }
        }
    }
}