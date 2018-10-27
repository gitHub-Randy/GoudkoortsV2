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
            i = 5;
            timerThread = new Thread(InitializeTimer);
            _railView.printView();
            _domain.ShedA = _levelMaker.ShedA;
            _domain.ShedB = _levelMaker.ShedB;
            _domain.ShedC = _levelMaker.ShedC;
            wagons = new List<LoadableObject>();
            StartInputThread();
            
      
            //startTimerThread();

            //while (true)
            //{
            //    _domain.ShedA.GenerateWagon();
            //    _domain.ShedB.GenerateWagon();
            //    _domain.ShedC.GenerateWagon();

            //    _railView.printView();
            //    Console.WriteLine("REPRINT");

            //    MoveAll();
            //    Console.WriteLine(wagons.Count);
            //    Console.ReadKey();
            //}

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
            aTimer = new System.Timers.Timer(100);
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
                i = 5;
                
            }

        }


        public void MoveAll()
        {
            if (_levelMaker.Object[4, 1].Object != null)
            {
                wagons.Add(_levelMaker.Object[4, 1].Object);
            }
            if (_levelMaker.Object[6, 1].Object != null)
            {
                wagons.Add(_levelMaker.Object[6, 1].Object);
            }
            if (_levelMaker.Object[9, 1].Object != null)
            {
                wagons.Add(_levelMaker.Object[9, 1].Object);
            }

            if(wagons.Count != 0)
            {
                foreach (LoadableObject n in wagons)
                {
                    n.Move();
                }
                
            }
            
        }



    }


}
