namespace TradeAndTravel
{
    using System.Linq;

    public static class PersonExtentions
    {
        public static bool HasItemInInventory(this Person actor, ItemType itemType)
        {
            return actor.ListInventory().Any(x => x.ItemType == itemType);
        }
    }
}
