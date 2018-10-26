using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class WhiteSpace : StaticObject
    {
        public WhiteSpace()
        {
            this.StandardSymbol = ' ';
            this.currentSymbol = StandardSymbol;
        }
        // Can obtain a wagon and deletes it
        public void DeleteObject()
        {

        }

        public override void DeleteObject(LoadableObject _object)
        {
            throw new NotImplementedException();
        }

        public override void PlaceObject(LoadableObject _object)
        {
            throw new NotImplementedException();
        }
    }
}