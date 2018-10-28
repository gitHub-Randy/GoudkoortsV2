using System;

namespace GoudkoortV2
{
    public class Ship : LoadableObject
    {
        int _load = 0;
        char unloadedSymbol = 'O';
        char loadedSymbol = '0';
        PierRail _pierRail;
        

        public Ship(StaticObject current)
        {
            this.CurrentPlace = current;
            this.Symbol = unloadedSymbol;
            this.CurrentPlace.Object = this;
            this.CurrentPlace.SetSymbol();
            this.CanMove = true;
            
        }
        public PierRail PierRail
        {
            get { return this._pierRail; }
            set { this._pierRail = value; }
        }

        public int Load
        {
            get { return this._load; }
            set { this._load = value; }
        }
        //can move foreward and handle load
        public override bool Move()
        {
            if (this.CanMove)
            {

                if (currentPlace.Next != null)
                {
                    StaticObject prev = this.CurrentPlace;
                    this.currentPlace.Next.PlaceObject(this);
                    
                    prev.Object = null;
                    prev.SetSymbol();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                if (this.Load > 7)
                {
                    this.CanMove = true;
                    this.Symbol = loadedSymbol;
                    this.CurrentPlace.SetSymbol();
                    Move();
                    
                    this.PierRail.BringInShip();
                    return true;
                    
                }
            }
            return true;
            
           
        }


    }
}