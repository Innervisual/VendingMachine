using System.Collections.Generic;

namespace VendingMachine
{
    public class Beverages : VendingItem
    {
        public static Beverages Pepsi = new Beverages { Index='a', Name="Pepsi Max", Price=15 };
        public static Beverages Cocacola = new Beverages { Index='b', Name="Coca Cola", Price=15 };
        public static Beverages Fanta = new Beverages { Index='c', Name="Fanta", Price=15 };
        public static Beverages SevenUp = new Beverages { Index='d', Name="Seven Up", Price=15 };



        public static List<Beverages> listOfBeverages = new List<Beverages> // - All products must be stored in one collection only.
        {
            Pepsi,
            Cocacola,
            Fanta,
            SevenUp
        };
    }
}
