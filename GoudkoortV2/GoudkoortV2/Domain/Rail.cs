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
            this.currentSymbol = standardSymbol;
            
        }

        public override void PlaceObject(LoadableObject _object)
        {
            if(this.Object == null)
            {
                this.Object = _object;
                this.SetSymbol();
                this.Object.CurrentPlace = this;
                
            }

           
        }
        // is the base Rail and can obtain a Object 


       
    }
}