using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class ArrangeRail : Rail
    {
        // can obtain a Wagon and can hold onto it

            public ArrangeRail()
        {
            this.StandardSymbol = 'O';
            this.currentSymbol = StandardSymbol;
        }
        public void LockWagon()
        {

        }
    }
}