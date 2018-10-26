using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class RailSwitchGiver :RailSwitch
    {
        private StaticObject upperNext;
        


        public StaticObject UpperPrev
        {
            get { return upperNext; }
            set { upperNext = value; }
        }

      
    }
}