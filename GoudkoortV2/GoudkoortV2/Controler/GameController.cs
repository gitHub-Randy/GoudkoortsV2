using GoudkoortV2.Controler;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;

namespace GoudkoortV2
{
    public class GameController
    {
        private RailWayView _railView;
        private ScoreView _scoreView;
        private ControlView _controlView;
        private RailWay _domain;
        private LevelMaker _levelMaker;
        private List<LoadableObject> wagons;
        private Thread keyInputThread;
        private Thread timerThread;
        private InputController _inputController;
        private System.Timers.Timer aTimer;
        private int i;

        public GameController()
        {
            _levelMaker = new LevelMaker();
            _domain = new RailWay();
            _railView = new RailWayView(_levelMaker.Object);
            _scoreView = new ScoreView();
            _controlView = new ControlView();
            _inputController = new InputController(this);
            keyInputThread = new Thread(_inputController.KeyInputEvent);
            i = 1;
            timerThread = new Thread(InitializeTimer);
            _domain.Ocean = _levelMaker.Ocean;
            _domain.Ocean.GenerateShip();
            _railView.printView();
            _domain.ShedA = _levelMaker.ShedA;
            _domain.ShedB = _levelMaker.ShedB;
            _domain.ShedC = _levelMaker.ShedC;
           
            wagons = new List<LoadableObject>();
            StartInputThread();
       

            startTimerThread();

            while (true)
            {
                _domain.ShedA.GenerateWagon();
                //_domain.ShedB.GenerateWagon();
                //_domain.ShedC.GenerateWagon();

                
                _railView.printView();
                Console.WriteLine("REPRINT");

                MoveAll();
                Console.WriteLine(wagons.Count);
                Console.ReadKey();
            }

            Console.ReadKey();
        }

        public LevelMaker getLevelMaker { get { return this._levelMaker; } }

        public RailWayView getRailView { get { return this._railView; } }


        public void StartInputThread()
        {
            keyInputThread.Start();
        
        }


        public void startTimerThread()
        {
            timerThread.Start();
        }

        public void InitializeTimer()
        {
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Start();
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine(i);
            i--;
            

            if (i == 0)
            {
                aTimer.Stop();
               
                keyInputThread.Suspend();
                Console.WriteLine("Alles wordt nu bewogen");
                //Thread.Sleep(3000);

                i = 1;

                _domain.ShedA.GenerateWagon();
                _domain.ShedB.GenerateWagon();
                _domain.ShedC.GenerateWagon();

                _railView.printView();
               
                
                MoveAll();
                InitializeTimer();
                keyInputThread.Resume();
                

            }

        }


        public void MoveAll()
        {
            if (_domain.ShedA.Next.Object != null)
            {
                wagons.Add(_domain.ShedA.Next.Object);
            }
            if (_domain.ShedB.Next.Object != null)
            {
                wagons.Add(_domain.ShedB.Next.Object);
            }
            if (_domain.ShedC.Next.Object != null)
            {
                wagons.Add(_domain.ShedC.Next.Object);
            }

            if (_domain.Ocean.Next.Object != null)
                {
                    wagons.Add(_domain.Ocean.Next.Object);
                }
            if (wagons.Count != 0)
            {
                foreach (LoadableObject n in wagons)
                {
                    n.Move();
                }
                
            }
            
        }



    }


}
