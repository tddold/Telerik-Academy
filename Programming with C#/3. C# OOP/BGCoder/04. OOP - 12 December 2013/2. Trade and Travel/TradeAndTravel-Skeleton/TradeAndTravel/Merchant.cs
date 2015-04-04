namespace TradeAndTravel
{
   public class Merchant : Shopkeeper, ITraveller
    {
       public Merchant(string name, Location location)
            : base(name, location)
        {
        }

        public virtual void TravelTo(Location location)
        {
            this.Location = location;
        }
    }
}
