using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public abstract class LoadableObject
    {
        public char symbol;
        public Rail currentPlace;
        public bool canMove;
        public Rail CurrentPlace
        {
            get { return this.currentPlace; }
            set { this.currentPlace = value; }
        }

        public abstract void Move();

        public char Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }

        }

        public bool CanMove
        {
            get { return this.canMove; }
            set { this.canMove = value; }
        }



    }
}