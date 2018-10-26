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

        public override void DeleteObject(LoadableObject _object)
        {
            this.Object = null;
        }

        public override void PlaceObject(LoadableObject _object)
        {
            if(this.Object == null)
            {
                this.Object = _object;
                this.SetSymbol();
            }
           
        }
        // is the base Rail and can obtain a Object 


       
    }
}