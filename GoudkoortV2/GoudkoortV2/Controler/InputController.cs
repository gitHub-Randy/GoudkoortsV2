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
            while (true)
            {
                ConsoleKey choice = Console.ReadKey().Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        this.RailSwitchTakers[1].Switch();
                        Console.Clear();
                        this.gamecontroller.getControlView.PrintControl();
                        this.gamecontroller.getRailView.printView();
                        break;
                    case ConsoleKey.D2:

                        this.RailSwitchGivers[0].Switch();
                        Console.Clear();
                        this.gamecontroller.getControlView.PrintControl();
                        this.gamecontroller.getRailView.printView();
                        break;
                    case ConsoleKey.D3:
                        this.RailSwitchTakers[0].Switch();
                        Console.Clear();
                        this.gamecontroller.getControlView.PrintControl();
                        this.gamecontroller.getRailView.printView();
                        break;
                    case ConsoleKey.D4:
                        this.RailSwitchTakers[2].Switch();
                        Console.Clear();
                        this.gamecontroller.getControlView.PrintControl();
                        this.gamecontroller.getRailView.printView();
                        break;
                    case ConsoleKey.D5:
                        this.RailSwitchGivers[1].Switch();
                        Console.Clear();
                        this.gamecontroller.getControlView.PrintControl();
                        this.gamecontroller.getRailView.printView();
                        break;
                    default:
                        break;
                }
            }
           
   
        }

    }
}
