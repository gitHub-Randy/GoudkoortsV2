using System;
using System.Collections.Generic;

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

        public GameController()
        {
            _levelMaker = new LevelMaker();
            _domain = new RailWay();
            _railView = new RailWayView(_levelMaker.Object);
            _scoreView = new ScoreView();
            _controlView = new ControlView();
            _railView.printView();
            _domain.ShedA = _levelMaker.ShedA;
            _domain.ShedB = _levelMaker.ShedB;
            _domain.ShedC = _levelMaker.ShedC;
            wagons = new List<LoadableObject>();
            while (true)
            {
                _domain.ShedA.GenerateWagon();
                _domain.ShedB.GenerateWagon();
                _domain.ShedC.GenerateWagon();
                _railView.printView();
                Console.WriteLine("REPRINT");
                Console.ReadKey();
                MoveAll();

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
