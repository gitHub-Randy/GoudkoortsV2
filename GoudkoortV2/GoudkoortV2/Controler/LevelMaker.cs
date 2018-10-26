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
            LinkTwoObjects(Object[4, 2], Object[4, 3]);
            LinkTwoObjects(Object[4, 3], Object[5, 3]);
            LinkTwoObjects(Object[5, 3], Object[5, 4]);
            LinkTwoObjects(Object[5, 4], Object[5, 5]);
            LinkTwoObjects(Object[5, 5], Object[4, 5]);
            LinkTwoObjects(Object[4, 5], Object[4, 6]);
            LinkTwoObjects(Object[4, 6], Object[4, 7]);
            LinkTwoObjects(Object[4, 7], Object[4, 8]);
            LinkTwoObjects(Object[4, 8], Object[4, 9]);
            LinkTwoObjects(Object[4, 9], Object[5, 9]);
            LinkTwoObjects(Object[5, 9], Object[5, 10]);
            LinkTwoObjects(Object[5, 10], Object[5, 11]);
            LinkTwoObjects(Object[5, 11], Object[4, 11]);
            LinkTwoObjects(Object[4, 11], Object[3, 11]);
            LinkTwoObjects(Object[3, 11], Object[2, 11]);
            LinkTwoObjects(Object[2, 11], Object[2, 10]);
            LinkTwoObjects(Object[2, 10], Object[2, 9]);
            LinkTwoObjects(Object[2, 9], Object[2, 8]);
            LinkTwoObjects(Object[2, 8], Object[2, 7]);
            LinkTwoObjects(Object[2, 7], Object[2, 6]);
            LinkTwoObjects(Object[2, 6], Object[2, 5]);
            LinkTwoObjects(Object[2, 5], Object[2, 4]);
            LinkTwoObjects(Object[2, 4], Object[2, 3]);
            LinkTwoObjects(Object[2, 3], Object[2, 2]);
            LinkTwoObjects(Object[2, 2], Object[2, 1]);
            LinkTwoObjects(Object[2, 1], Object[2, 0]);
            LinkTwoObjects(Object[6, 0], Object[6, 1]);
            LinkTwoObjects(Object[6, 1], Object[6, 2]);
            LinkTwoObjects(Object[6, 2], Object[6, 3]);
            LinkTwoObjects(Object[6, 3], Object[5, 3]);
            LinkTwoObjects(Object[9, 0], Object[9, 1]);
            LinkTwoObjects(Object[9, 1], Object[9, 2]);
            LinkTwoObjects(Object[9, 2], Object[9, 3]);
            LinkTwoObjects(Object[9, 3], Object[9, 4]);
            LinkTwoObjects(Object[9, 4], Object[9, 5]);
            LinkTwoObjects(Object[9, 5], Object[9, 6]);
            LinkTwoObjects(Object[9, 6], Object[8, 6]);
            LinkTwoObjects(Object[8, 6], Object[8, 7]);
            LinkTwoObjects(Object[8, 7], Object[8, 8]);
            LinkTwoObjects(Object[8, 8], Object[7, 8]);
            LinkTwoObjects(Object[7, 8], Object[6, 8]);
            LinkTwoObjects(Object[6, 8], Object[6, 9]);
            LinkTwoObjects(Object[6, 9], Object[5, 9]);
            
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