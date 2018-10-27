using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudkoortV2.Controler
{
    class InputController
    {
        GameController gamecontroller;
        List<RailSwitchGiver> RailSwitchGivers;
        List<RailSwitchTaker> RailSwitchTakers;


        public InputController(GameController gameController)
        {
            gamecontroller = gameController;
            RailSwitchGivers = gamecontroller.getLevelMaker.getSwitchGivers;
            RailSwitchTakers = gamecontroller.getLevelMaker.getSwitchTakers;

        }

        public void KeyInputEvent()
        {
            ConsoleKey choice = Console.ReadKey().Key;
            switch (choice)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    return;
                case ConsoleKey.D2:
                    Console.Clear();
                    return;
                case ConsoleKey.D3:
                    Console.Clear();
                    return;
                case ConsoleKey.D4:
                    Console.Clear();
                    return;
                case ConsoleKey.D5:
                    Console.Clear();
                    return;
                default:
                    return;
            }
        }

    }
}
