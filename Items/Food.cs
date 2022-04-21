using System.Collections.Generic;

namespace VendingMachine
{
    public class Food : VendingItem
    {
        public static Food Sandwich = new Food { Index='e', Name="Sandwich", Price=30 };
        public static Food Waffle = new Food { Index='f', Name="Waffle", Price=30 };
        public static Food Soup = new Food { Index='g', Name="Soup", Price=15 };

        public static List<Food> listOfFood = new List<Food> // - All products must be stored in one collection only.
        {
            Sandwich,
            Waffle,
            Soup
        };
    }
}
