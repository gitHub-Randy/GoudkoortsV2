using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public class GameController
    {
        private RailWayView _railView;
        private ScoreView _scoreView;
        private ControlView _controlView;
        private RailWay _domain;
        private LevelMaker _levelMaker;

        public GameController()
        {
            _levelMaker = new LevelMaker();
            _domain = new RailWay();
            _railView = new RailWayView();
            _scoreView = new ScoreView();
            _controlView = new ControlView();
            _levelMaker.PrintArr();
        }
    }
}