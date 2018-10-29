using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public abstract class StaticObject
    {
        protected StaticObject _next;
        protected LoadableObject _object;
        protected char currentSymbol;
        protected char standardSymbol;

        public char CurrentSymbol
        {
            get { return this.currentSymbol; }
            set { this.currentSymbol = value; }
        }

        public char StandardSymbol
        {
            get { return this.standardSymbol; }
            set { this.standardSymbol = value; }
        }


        public StaticObject Next
        {
            get { return this._next; }
            set { this._next = value; }
        }

        public LoadableObject Object
        {
            get { return this._object; }
            set { this._object = value; }
        }

        public abstract bool PlaceObject(LoadableObject _object);
     

        public virtual void SetSymbol()
        {
            if (this.Object == null)
            {
                this.currentSymbol = this.standardSymbol;
            }
            else
            {
                this.currentSymbol = this.Object.Symbol;
            }
        }
    }
       
}