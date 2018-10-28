using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class Score
    {
        private int _score;

        public Score()
        {
            this.ScoreNumber = 0;
        }

        public int ScoreNumber
        {
            get { return this._score; }
            set { this._score = value; }
        }
    }
}