namespace GoudkoortV2
{
    public class ArrangeRail : Rail
    {
        // can obtain a Wagon and can hold onto it

        public ArrangeRail()
        {
            this.StandardSymbol = 'O';
            this.currentSymbol = StandardSymbol;
        }
        public void LockWagon()
        {
            if (this.Next == null)
            {
                this.Object.CanMove = false;
            }
            else if (this.Next.Object != null && !this.Next.Object.CanMove)
            {
                this.Object.CanMove = false;
            }

        }

        public override void PlaceObject(LoadableObject _object)
        {
            if (this.Object == null)
            {
                this.Object = _object;
                this.SetSymbol();
                this.Object.CurrentPlace = this;
                LockWagon();

            }


        }
    }
}