using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class WaterPier : StaticObject
    {
        PierRail _pierRail;
        Ship _ship;
        Ocean _ocean;


        public WaterPier()
        {
            this.StandardSymbol = '+';
            this.CurrentSymbol = standardSymbol;
            this.SetSymbol();
        }

        public Ocean Ocean
        {
            get { return this._ocean; }
            set { this._ocean = value; }
        }
        public PierRail Pier
        {
            get { return this._pierRail; }
            set { this._pierRail = value; }
        }

        public Ship Ship
        {
            get { return this._ship; }
            set { this._ship = value; }
        }



        public override void DeleteObject(LoadableObject _object)
        {
            throw new NotImplementedException();
        }



        public override void PlaceObject(LoadableObject _object)
        {
            if (this.Object == null)
            {
                this.Ship = (Ship)_object;
                this.Ship.PierRail = this.Pier;
                this.SetSymbol();
                this.Ship.CurrentPlace = this;
                this.Ship.CanMove = false;

            }
        }

        internal void CallNextShip()
        {
            this._ocean.GenerateShip();
        }

        public new void SetSymbol()
        {
            if (this.Ship == null)
            {
                this.currentSymbol = this.standardSymbol;
            }
            else
            {
                this.currentSymbol = this.Ship.Symbol;
            }
        }
    }
}