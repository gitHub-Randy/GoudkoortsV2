using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class RailWay
    {
        Shed _shedA;
        Shed _shedB;
        Shed _shedC;
        List<LoadableObject> currentWagons;
        public RailWay()
        {
             
        }


        public Shed ShedA
        {
            get { return this._shedA; }
            set { this._shedA = value; }
        }
        public Shed ShedB
        {
            get { return this._shedB; }
            set { this._shedB = value; }
        }
        public Shed ShedC
        {
            get { return this._shedC; }
            set { this._shedC = value; }
        }
    }
}