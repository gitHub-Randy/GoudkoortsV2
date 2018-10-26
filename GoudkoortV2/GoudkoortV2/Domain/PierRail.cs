using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class PierRail : Rail
    {
        // can have a wagon and looks if it has a ship and a wagon and transfers load

            public PierRail()
        {
            this.StandardSymbol = 'K';
            this.currentSymbol = StandardSymbol;
        }
        public void GetLoadFromWagon()
        {

        }

        public void GiveLoadToShip()
        {

        }
    }
}