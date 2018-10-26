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
            this.StandardSymbol = 'S';
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
    }
}