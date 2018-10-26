using System;
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



        String[] lines;
        int numberOfRows;
        int lengthOfRows;
        char[,] char2d;
        StaticObject[,] _object;


        public LevelMaker()
        {
            lines = System.IO.File.ReadAllLines("Goudkoorts.txt");
            numberOfRows = lines.Length;
            lengthOfRows = lines[0].Length;
            char2d = new Char[numberOfRows, lengthOfRows];
            _object = new StaticObject[numberOfRows, lengthOfRows];
            ReadTextFile();
            MakeObjects();
        }

        public void ReadTextFile()
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                var s = lines[i].ToCharArray();

                for (int j = lengthOfRows - 1; j >= 0; j--)
                {
                    char2d[i, j] = s[j];
                }
            }
        }


        public StaticObject[,] Object
        {
            get { return this._object; }
        }




        public void MakeObjects()
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = lengthOfRows - 1; j >= 0; j--)
                {
                    char character = char2d[i, j];

                    switch (character)
                    {
                        case '-':
                            //MakeWater();
                            Object[i, j] = new Rail();
                            break;
                        case '+':
                            //MakeShip();
                            Object[i, j] = new Rail(); // ship erop zetten
                            break;
                        case 'K':
                            //MakeEmptySpace();
                            Object[i, j] = new PierRail();
                            break;
                        case 'R':
                            //MakeRail();
                            Object[i, j] = new ArrangeRail();
                            break;
                        case 'A':
                            Object[i, j] = new Shed();
                            break;
                        case 'B':
                            Object[i, j] = new Shed();
                            break;
                        case 'C':
                            //MakePier();
                            Object[i, j] = new Shed();
                            break;
                        case 'S':
                            
                            Object[i, j] = new RailSwitchTaker();
                            railSwitches.Add((RailSwitch)Object[i, j]);
                            break;
                        case 's':
                            Object[i, j] = new RailSwitchGiver();
                            railSwitches.Add((RailSwitch)Object[i, j]);
                            break;
                        default:
                            break;

                    }
                }

            }
            Console.WriteLine("HAIIII");

        }

        public void PrintArr()
        {
            for (int i = 0; i < numberOfRows ; i++)
            {
                for (int j = 0; j < lengthOfRows-1; j++)
                {
                    Console.Write(i+","+j+" ");
                }
                Console.WriteLine();
            }
        }


        public void LinkTwoObjects(StaticObject current, StaticObject Next)
        {
            current.Next = Next;
        }


        public void Link()
        {
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 1], Object[4, 2]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 0], Object[4, 1]);

        }









        //public void MakeObjects()
        //{
        //    shedA = new Shed();
        //    shedB = new Shed();
        //    shedC = new Shed();

        //    for (int i = 0; i < 47; i++)
        //    {
        //        railObjects.Add(new Rail());
        //    }

        //    railSwitches[0] = new RailSwitchTaker();
        //    railSwitches[1] = new RailSwitchGiver();
        //    railSwitches[2] = new RailSwitchTaker();
        //    railSwitches[3] = new RailSwitchTaker();
        //    railSwitches[4] = new RailSwitchGiver();

        //    for (int i = 0; i < 8; i++)
        //    {
        //        arrangeRails.Add(new ArrangeRail());
        //    }


        //}


    }
}