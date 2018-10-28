using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class Wagon : LoadableObject

    {
        public Wagon(StaticObject current)
        {
            this.Symbol = 'W';
            this.CurrentPlace = (StaticObject)current;
            this.CanMove = true;
        }

        //can move foreward and handle load
        protected  void GiveLoad()
        {
            throw new NotImplementedException();
        }

        public override bool Move()
        {
            if (this.CanMove)
            {
                if (currentPlace.Next != null)
                {

                    StaticObject prev = this.CurrentPlace;

                    if (this.currentPlace.Next.PlaceObject(this))
                    {
                        this.currentPlace.SetSymbol();
                        prev.Object = null;
                        prev.SetSymbol();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                   
                }
                
            }
            return true;
            
        }
    }
}