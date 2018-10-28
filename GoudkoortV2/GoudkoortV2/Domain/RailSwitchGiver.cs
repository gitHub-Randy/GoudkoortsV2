using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class RailSwitchGiver :RailSwitch
    {
        private StaticObject underNext;
        private StaticObject upperNext;
        
        public RailSwitchGiver()
        {
            this.StandardSymbol = '/';
            this.currentSymbol = StandardSymbol;
        }

        public StaticObject UnderNext
        {
            get { return underNext; }
            set { underNext = value; }
        }

        public StaticObject UpperNext
        {
            get { return this.upperNext; }
            set { upperNext = value; }
        }

        public override void Switch()
        {
            if (this.CurrentSymbol == '/' && this.Object == null)
            {
                this.Next = this.UnderNext;
                this.standardSymbol = '\\';
                this.SetSymbol();
            }
            else if (this.Object == null)
            {
                this.Next = this.UpperNext;
                this.standardSymbol = '/';
                this.SetSymbol();
            }

        }

        public override  void SetSymbol()
        {
            if(this.Object == null)
            {
                this.CurrentSymbol = StandardSymbol;
            }
            else
            {
                this.CurrentSymbol = this.Object.Symbol;
            }
            
        }


    }
}