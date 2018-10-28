using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class WagonShed : Shed
    {

        Random r;
        // Generates Wagon and puts it on the nearest Rail
        public WagonShed(char sym)
        {
            this.StandardSymbol = sym;
        }

        public override void DeleteObject(LoadableObject _object)
        {
            throw new NotImplementedException();
        }



        public override bool PlaceObject(LoadableObject _object)
        {
           
                this.Object = _object;
                this.SetSymbol();
                this.Object.CurrentPlace = this;
                return true;
            
        }

        public void GenerateWagon()
        {
            r = new Random();
            int x = r.Next(0, 100);

            //int x = 23;
            if (x < 24)
            {
                this.PlaceObject(new Wagon(this));
             
                Console.WriteLine("GEnerated Wagon");
            }
        }
    }
}