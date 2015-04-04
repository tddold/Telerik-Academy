namespace TradeAndTravel
{
    public class Iron : Item
    {
        private const int InitialValue = 3;

        public Iron(string name, Location location = null)
            : base(name, Iron.InitialValue, ItemType.Iron, location)
        {

        }
    }
}
