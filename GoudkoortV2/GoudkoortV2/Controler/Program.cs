using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudkoortV2
{
    class Program
    {
        public GameController controller;
        static void Main(string[] args)
        {
            GameController controller = new GameController();
            Console.ReadKey();
        }
    }
}
