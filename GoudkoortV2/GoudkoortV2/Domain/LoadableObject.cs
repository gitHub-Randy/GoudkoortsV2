using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public abstract class LoadableObject
    {
        public char symbol;
        public StaticObject currentPlace;
        public bool canMove;
        public StaticObject CurrentPlace
        {
            get { return this.currentPlace; }
            set { this.currentPlace = value; }
        }

        public abstract bool Move();

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