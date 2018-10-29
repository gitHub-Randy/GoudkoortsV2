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
            this.StandardSymbol = '-';
            this.currentSymbol = StandardSymbol;
        }

       
        public override bool PlaceObject(LoadableObject _object)
        {
             
            if(this.Object == null)
            {
                this.Object = _object;
                this.SetSymbol();
                this.Object.CurrentPlace = this;
                return true;
            }
            else
            {
                return false;
            }

           
        }
        // is the base Rail and can obtain a Object 
       
    }
}