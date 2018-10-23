using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudkoortV2
{
    class MainController
    {
        // Main controller that starts and controls the gameflow

        private GameController _game;
        private MenuView _menu;
        public MainController()
        {
            _menu = new MenuView();
            _game = new GameController();
        }
    }
}
