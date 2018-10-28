using System;
using System.Collections.Generic;

namespace GoudkoortV2
{
    public class LevelMaker
    {
        // Generates All Model Objects and links them
        List<Rail> railObjects = new List<Rail>();
        List<RailSwitchTaker> railSwitchTakers = new List<RailSwitchTaker>();
        List<RailSwitchGiver> railSwitchGivers = new List<RailSwitchGiver>();
        List<ArrangeRail> arrangeRails = new List<ArrangeRail>();
        PierRail pier;
        WagonShed shedA;
        WagonShed shedB;
        WagonShed shedC;
        EndRail shipEnd;
        EndRail wagonEnd;
        Ocean ocean;
        Score _score;

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
            Link();
            this.ShedA = (WagonShed)Object[4, 0];
            this.ShedB = (WagonShed)Object[6, 0];
            this.ShedC = (WagonShed)Object[9, 0];
            this.wagonEnd = (EndRail)Object[2, 0];
            this.shipEnd = (EndRail)Object[1, 0];
            this.ocean = (Ocean)Object[1, 12];
          
        }

        public List<RailSwitchGiver> getSwitchGivers { get { return this.railSwitchGivers; } }
        public List<RailSwitchTaker> getSwitchTakers { get { return this.railSwitchTakers; } }

        public Score Score
        {
            get { return this._score; }
            set { this._score = value; }
        }
        public WagonShed ShedA
        {
            get { return this.shedA; }
            set { this.shedA = value; }
        }
        public WagonShed ShedB
        {
            get { return this.shedB; }
            set { this.shedB = value; }
        }
        public WagonShed ShedC
        {
            get { return this.shedC; }
            set { this.shedC = value; }
        }

        public Ocean Ocean
        {
            get { return this.ocean; }
            set { this.ocean = value; }
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


        public EndRail ShipEnd
        {
            get { return this.shipEnd; }
            set { this.shipEnd = value; }
        }

        public EndRail WagonEnd
        {
            get { return this.wagonEnd; }
            set { this.wagonEnd = value; }
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
                       
                        case 'K':
                            //MakeEmptySpace();
                            Object[i, j] = new PierRail(this.Score);
                            break;
                        case 'R':
                            //MakeRail();
                            Object[i, j] = new ArrangeRail();
                            break;
                        case 'A':
                            Object[i, j] = new WagonShed('A');
                            
                            break;
                        case 'B':
                            Object[i, j] = new WagonShed('B');
                           
                            break;
                        case 'C':
                            //MakePier();
                            Object[i, j] = new WagonShed('C');
                            break;
                        case '=':
                            //MakePier();
                            Object[i, j] = new Ocean();
                            break;
                        case 'S':
                            Object[i, j] = new RailSwitchTaker();
                            railSwitchTakers.Add((RailSwitchTaker)Object[i, j]);
                            break;
                        case 's':
                            Object[i, j] = new RailSwitchGiver();
                            railSwitchGivers.Add((RailSwitchGiver)Object[i, j]);
                            break;
                        case '.':
                            Object[i, j] = new WhiteSpace();
                            break;
                        case '+':
                            Object[i, j] = new WaterPier();
                            break;
                        case 'D':
                            Object[i, j] = new EndRail();
                            break;
                        default:
                            break;

                    }
                }

            }

        }


        public void LinkTwoObjects(StaticObject current, StaticObject Next)
        {
            current.Next = Next;
        }


        public void Link()
        {

            LinkTwoObjects(Object[1, 12], Object[1, 11]);
            LinkTwoObjects(Object[1, 11], Object[1, 10]);
            LinkTwoObjects(Object[1, 10], Object[1, 9]);
            LinkTwoObjects(Object[1, 9], Object[1, 8]);
            LinkTwoObjects(Object[1, 8], Object[1, 7]);
            LinkTwoObjects(Object[1, 7], Object[1, 6]);
            LinkTwoObjects(Object[1, 6], Object[1, 5]);
            LinkTwoObjects(Object[1, 5], Object[1, 4]);
            LinkTwoObjects(Object[1, 4], Object[1, 3]);
            LinkTwoObjects(Object[1, 3], Object[1, 2]);
            LinkTwoObjects(Object[1, 2], Object[1, 1]);
            LinkTwoObjects(Object[1, 1], Object[1, 0]);

            this.Score = new Score();
            PierRail pier = new PierRail(this.Score);
            pier.Ocean = (Ocean)Object[1, 12];
            Object[2, 9] = pier;

            WaterPier waterpier = (WaterPier)Object[1, 9];
            waterpier.Pier = (PierRail)Object[2, 9];
           
            pier.PierWater = waterpier;

            pier.Next = Object[2, 8];

            Object[2, 8].Next = Object[2, 7];
           
            Ocean shipShed = (Ocean)Object[1, 12];
         
            waterpier.Ocean = shipShed;

            LinkTwoObjects(Object[4, 0], Object[4, 1]);
            LinkTwoObjects(Object[4, 1], Object[4, 2]);
            LinkTwoObjects(Object[4, 2], Object[4, 3]);
            LinkTwoObjects(Object[4, 3], Object[5, 3]);
            LinkTwoObjects(Object[5, 3], Object[5, 4]);
            LinkTwoObjects(Object[5, 4], Object[5, 5]);
        
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
          
            LinkTwoObjects(Object[6, 5], Object[7, 5]);
            LinkTwoObjects(Object[7, 5], Object[7, 6]);
            LinkTwoObjects(Object[7, 6], Object[8, 6]);

            LinkTwoObjects(Object[9, 0], Object[9, 1]);
            LinkTwoObjects(Object[9, 1], Object[9, 2]);
            LinkTwoObjects(Object[9, 2], Object[9, 3]);
            LinkTwoObjects(Object[9, 3], Object[9, 4]);
            LinkTwoObjects(Object[9, 4], Object[9, 5]);
            LinkTwoObjects(Object[9, 5], Object[9, 6]);
                
            LinkTwoObjects(Object[8, 7], Object[8, 8]);
       
            LinkTwoObjects(Object[7, 8], Object[6, 8]);
            LinkTwoObjects(Object[6, 8], Object[6, 9]);

            railSwitchTakers[0].UpperPrev = Object[4, 9];
            railSwitchTakers[0].UnderPrev = Object[6, 9];
            railSwitchTakers[0].Next = Object[5, 10];

            railSwitchTakers[1].UnderPrev = Object[6, 3];
            railSwitchTakers[1].UpperPrev = Object[4, 3];
            railSwitchTakers[1].Next = Object[5, 4];
            LinkTwoObjects(Object[5, 4], Object[5, 5]);

            railSwitchTakers[2].UpperPrev = Object[7, 6];
            railSwitchTakers[2].UnderPrev = Object[9, 6];
            railSwitchTakers[2].Next = Object[8, 7];

            railSwitchGivers[0].UnderNext = Object[6, 5];
            railSwitchGivers[0].UpperNext = Object[4, 5];
            railSwitchGivers[0].Next = Object[4, 5];

            railSwitchGivers[1].UnderNext = Object[9, 8];
            railSwitchGivers[1].UpperNext = Object[7, 8];
            railSwitchGivers[1].Next = Object[7, 8];

            LinkTwoObjects(Object[6, 8], Object[6, 9]);

            LinkTwoObjects(Object[9, 8], Object[9, 9]);
            LinkTwoObjects(Object[9, 9], Object[9, 10]);
            LinkTwoObjects(Object[9, 10], Object[9, 11]);
            LinkTwoObjects(Object[9, 11], Object[10, 11]);

            LinkTwoObjects(Object[9, 12], Object[10, 12]);

            LinkTwoObjects(Object[10, 11], Object[10, 10]);
            LinkTwoObjects(Object[10, 10], Object[10, 9]);
            LinkTwoObjects(Object[10, 9], Object[10, 8]);
            LinkTwoObjects(Object[10, 8], Object[10, 7]);
            LinkTwoObjects(Object[10, 7], Object[10, 6]);
            LinkTwoObjects(Object[10, 6], Object[10, 5]);
            LinkTwoObjects(Object[10, 5], Object[10, 4]);
            LinkTwoObjects(Object[10, 4], Object[10, 3]);
            LinkTwoObjects(Object[10, 3], Object[10, 2]);
            LinkTwoObjects(Object[10, 2], Object[10, 1]);
    

        }

    }
}