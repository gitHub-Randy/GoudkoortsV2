using System.Collections.Generic;

namespace GoudkoortV2
{
    public class LevelMaker
    {
        // Generates All Model Objects and links them
        List<Rail> railObjects = new List<Rail>();
        List<RailSwitch> railSwitches = new List<RailSwitch>();
        List<ArrangeRail> arrangeRails = new List<ArrangeRail>();
        PierRail pier = new PierRail();
        Shed shedA;
        Shed shedB;
        Shed shedC;

        public void MakeObjects()
        {
            shedA = new Shed();
            shedB = new Shed();
            shedC = new Shed();

            for (int i = 0; i < 47; i++)
            {
                railObjects.Add(new Rail());
            }

            railSwitches[0] = new RailSwitchTaker();
            railSwitches[1] = new RailSwitchGiver();
            railSwitches[2] = new RailSwitchTaker();
            railSwitches[3] = new RailSwitchTaker();
            railSwitches[4] = new RailSwitchGiver();

            for (int i = 0; i < 8; i++)
            {
                arrangeRails.Add(new ArrangeRail());
            }


        }

        public void LinkObjects()
        {
            shedA.Next = railObjects[0];

        }
    }
}