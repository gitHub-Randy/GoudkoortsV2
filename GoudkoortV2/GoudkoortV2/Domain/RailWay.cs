using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class RailWay
    {
        WagonShed _shedA;
        WagonShed _shedB;
        WagonShed _shedC;
        Ocean _ocean;
        List<LoadableObject> currentWagons;
        public RailWay()
        {
             
        }

        public Ocean Ocean
        {
            get { return this._ocean; }
            set { this._ocean = value; }
        }
        public WagonShed ShedA
        {
            get { return this._shedA; }
            set { this._shedA = value; }
        }
        public WagonShed ShedB
        {
            get { return this._shedB; }
            set { this._shedB = value; }
        }
        public WagonShed ShedC
        {
            get { return this._shedC; }
            set { this._shedC = value; }
        }
    }
}