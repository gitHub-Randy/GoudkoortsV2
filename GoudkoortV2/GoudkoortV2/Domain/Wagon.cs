using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class Wagon : LoadableObject

    {
      

        Rail currentPlace;

        public Wagon(StaticObject current)
        {
            this.Symbol = 'W';
            this.CurrentPlace = (Rail)current;
        }

       
        protected Rail CurrentPlace
        {
            get { return this.currentPlace; }
            set { this.currentPlace = value; }
        }

        //can move foreward and handle load
        protected  void GiveLoad()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            this.currentPlace.Next.PlaceObject(this);
            
        }
    }
}