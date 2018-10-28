using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class RailSwitchTaker :RailSwitch
    {
        private StaticObject upperPrev;
        private StaticObject underPrev;

        public RailSwitchTaker()
        {
            this.StandardSymbol = '\\';
            this.currentSymbol = StandardSymbol;
        }
        public StaticObject UpperPrev
        {
            get { return upperPrev; }
            set { upperPrev = value; }
        }

        public StaticObject UnderPrev
        {
            get { return underPrev; }
            set { underPrev = value; }
        }

        public override void Switch()
        {
            if(this.CurrentSymbol == '/' && this.Object == null)
            {
                this.UpperPrev.Next = this;
                this.CurrentSymbol = '\\';
                this.UnderPrev.Next = null;
            }
            else if (this.Object == null)
            {
                this.UnderPrev.Next = this;
                this.CurrentSymbol = '/';
                this.UpperPrev.Next = null;
            }
            
        }
    }
}