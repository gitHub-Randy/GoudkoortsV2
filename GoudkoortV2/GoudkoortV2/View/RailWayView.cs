using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class RailWayView
    {

        private StaticObject[,] objects;
        private int numberOfRows = 11;
        private int lengthOfRows = 13;

        public RailWayView(StaticObject[,] objects)
        {
            this.objects = objects;
        }

        public void printView()
        {
            Console.Clear();
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < lengthOfRows - 1; j++)
                {
                    Console.Write(objects[i, j].CurrentSymbol);
                }
                Console.WriteLine();
            }
        }

        public StaticObject[,] Objects
        {
            get { return this.objects; }
            set { this.objects = value; }
        }
    }
}