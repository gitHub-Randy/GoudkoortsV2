using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class EndRail : Rail
    {

        public void deleteObject()
        {
            this.Object = null;
            this.SetSymbol();
        }

        public override bool PlaceObject(LoadableObject _object)
        {

            if (this.Object == null)
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
    }
}