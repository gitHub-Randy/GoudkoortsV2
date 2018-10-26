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
    }
}