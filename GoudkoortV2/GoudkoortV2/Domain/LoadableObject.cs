using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public abstract class LoadableObject
    {
        char symbol;
        protected StaticObject _currentField { get; set; }

        public abstract void Move();

        public char Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }

        }



    }
}