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
        EndRail wagonEnd;
        EndRail shipEnd;
      
        List<LoadableObject> currentWagons;
        Score score;
        public RailWay(Score _score)
        {
            score = _score;
            currentWagons = new List<LoadableObject>();
        }


        public bool MoveWagons()
        {
            bool crash = false;
            if (ShedA.Object != null)
            {
                currentWagons.Add(ShedA.Object);
            }
            if (ShedB.Object != null)
            {
                currentWagons.Add(ShedB.Object);
            }
            if (ShedC.Object != null)
            {
                currentWagons.Add(ShedC.Object);
            }
            if(wagonEnd.Object != null)
            {
                currentWagons.Remove(wagonEnd.Object);
                wagonEnd.deleteObject();
            }
            if (shipEnd.Object != null)
            {
                currentWagons.Remove(shipEnd.Object);
                shipEnd.deleteObject();
            }

            if (Ocean.Next.Object != null)
            {
                currentWagons.Add(Ocean.Next.Object);
            }
            if (currentWagons.Count != 0)
            {
                foreach (LoadableObject n in currentWagons)
                {
                    if (!n.Move())
                    {
                        crash = true ;
                    }
                  
                }

            }
            return crash;
        }

        public Ocean Ocean
        {
            get { return this._ocean; }
            set { this._ocean = value; }
        }

        public EndRail ShipEnd
        {
            get { return this.shipEnd; }
            set { this.shipEnd = value; }
        }

        public EndRail WagonEnd
        {
            get { return this.wagonEnd; }
            set { this.wagonEnd = value; }
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

        public Score Score
        {
            get { return this.score; }
            set { this.score = value; }
        }
    }
}