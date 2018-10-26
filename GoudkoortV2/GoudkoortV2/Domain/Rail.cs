using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public  class Rail : StaticObject
    {
        public Rail()
        {
            this.Symbol = '-';
        }
        // is the base Rail and can obtain a Object 
        protected  bool PlaceObject()
        {

            return false;
        }
    }
}