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



        public override void PlaceObject(LoadableObject _object)
        {
            throw new NotImplementedException();
        }

        public void GenerateWagon()
        {
            r = new Random();
            int x = r.Next(0, 100);


            if (x < 24)
            {
                this.Next.PlaceObject(new Wagon(this.Next));
                this.Next.SetSymbol();
                Console.WriteLine("GEnerated Wagon");
            }
        }
    }
}