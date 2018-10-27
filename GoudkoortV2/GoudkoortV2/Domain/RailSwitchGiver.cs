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
            this.StandardSymbol = '\\';
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
            if (this.CurrentSymbol == '/')
            {
                this.Next = this.UnderNext;
                this.currentSymbol = '\\';
            }
            else
            {
                this.Next = this.UpperNext;
                this.currentSymbol = '/';
            }

        }
    }
}