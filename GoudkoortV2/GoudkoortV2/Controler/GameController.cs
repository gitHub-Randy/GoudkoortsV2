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
        private GameOverView gameOverView;
        private int i;

        public GameController()
        {
            _levelMaker = new LevelMaker();
            _domain = new RailWay(_levelMaker.Score);
            _railView = new RailWayView(_levelMaker.Object);
            _scoreView = new ScoreView();
            _controlView = new ControlView();
            _inputController = new InputController(this);
            keyInputThread = new Thread(_inputController.KeyInputEvent);
            i = 5;
            timerThread = new Thread(InitializeTimer);
            _domain.Ocean = _levelMaker.Ocean;
            gameOverView = new GameOverView();
           
            _domain.ShedA = _levelMaker.ShedA;
            _domain.ShedB = _levelMaker.ShedB;
            _domain.ShedC = _levelMaker.ShedC;
            _domain.ShipEnd = _levelMaker.ShipEnd;
            _domain.WagonEnd = _levelMaker.WagonEnd;
            _domain.Ocean.GenerateLoadableObject();
            wagons = new List<LoadableObject>();
            StartInputThread();
       

            startTimerThread();
            _controlView.PrintControl();
            _railView.printView();


           
        }

        public RailWayView getRailView { get { return this._railView; } }

        public ControlView getControlView { get { return this._controlView; } }

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
                MoveAll();
                Thread.Sleep(3000);

                i = 5;

                _domain.ShedA.GenerateLoadableObject();
                _domain.ShedB.GenerateLoadableObject();
                _domain.ShedC.GenerateLoadableObject();
                _controlView.PrintControl();
                _railView.printView();
                _scoreView.PrintScore(this.GetScore());
                
                
                InitializeTimer();
                keyInputThread.Resume();
                

            }

        }


        public void MoveAll()
        {

            if (_domain.MoveWagons())
            {

                gameOverView.GameOverMessage();
                Console.Read();
                Environment.Exit(0);
            }
            
           
        }


        public int GetScore()
        {
            return _domain.Score.ScoreNumber;
        }


        public LevelMaker getLevelMaker
        {
            get { return this._levelMaker; }
            set { this._levelMaker = value; }
        }
    }


}
