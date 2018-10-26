using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class RailSwitchGiver :RailSwitch
    {
        private StaticObject underNext;
        


        public StaticObject UnderNext
        {
            get { return underNext; }
            set { underNext = value; }
        }

      
    }
}