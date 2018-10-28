namespace GoudkoortV2
{
    public class PierRail : Rail
    {
        // can have a wagon and looks if it has a ship and a wagon and transfers load

        WaterPier _pierWater;
        Ocean _ocean;
        Score _score;
        public WaterPier PierWater
        {
            get { return this._pierWater; }
            set { this._pierWater = value; }
        }

        public Ocean Ocean
        {
            get { return this._ocean; }
            set { this._ocean = value; }
        }

        public PierRail(Score score)
        {
            this.StandardSymbol = 'K';
            this.currentSymbol = StandardSymbol;
            this.Score = score;
        }


        public void GiveLoadToShip()
        {
            if(this.PierWater.Ship != null)
            {
                this.Object.Symbol = 'w';
                PierWater.Ship.Load += 1;
                this.Score.ScoreNumber += 1;
                if (PierWater.Ship.Load == 8)
                {
                    this.Score.ScoreNumber += 10;
                }
            }      

        }

        public override bool PlaceObject(LoadableObject _object)
        {
            if (this.Object == null)
            {
                this.Object = _object;
                this.SetSymbol();
                this.Object.CurrentPlace = this;
                GiveLoadToShip();
                return true;
            }
            else
            {
                return false;
            }


        }

        public void BringInShip()
        {
            this.Ocean.GenerateLoadableObject();
        }

        public Score Score
        {
            get { return this._score; }
            set { this._score = value; }
        }
    }
}