namespace GoudkoortV2
{
    public class PierRail : Rail
    {
        // can have a wagon and looks if it has a ship and a wagon and transfers load

        WaterPier _pierWater;
        Ocean _ocean;
        Score score;
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

        public PierRail()
        {
            this.StandardSymbol = 'K';
            this.currentSymbol = StandardSymbol;
        }


        public void GiveLoadToShip()
        {
            if(this.PierWater.Ship != null)
            {
                PierWater.Ship.Load += 1;
            }
            this.Object.Symbol = 'w';


            this.score.ScoreNumber +=1;
            if(PierWater.Ship.Load == 8)
            {
                this.score.ScoreNumber += 10;
            }

        }

        public override void PlaceObject(LoadableObject _object)
        {
            if (this.Object == null)
            {
                this.Object = _object;
                this.SetSymbol();
                this.Object.CurrentPlace = this;
                GiveLoadToShip();

            }


        }

        public void BringInShip()
        {
            this.Ocean.GenerateShip();
        }

        public Score Score
        {
            get { return this.score; }
            set { this.score = value; }
        }
    }
}