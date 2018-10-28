using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class Ocean : Shed
    {

       public Ocean()
        {
            this.StandardSymbol = '=';
        }

        public override void DeleteObject(LoadableObject _object)
        {
            throw new NotImplementedException();
        }

        public override bool PlaceObject(LoadableObject _object)
        {
            throw new NotImplementedException();
        }

        public void GenerateShip()
        {
            this.Next.Object = new Ship(this.Next);

        }
    }
}