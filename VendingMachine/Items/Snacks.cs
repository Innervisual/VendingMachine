using System.Collections.Generic;

namespace VendingMachine
{
    public class Snacks : VendingItem
    {

        public static Snacks Snickers = new Snacks { Index='h', Name="Snickers", Price=20 };
        public static Snacks Mars = new Snacks { Index='i', Name="Mars", Price=20 };
        public static Snacks Twist = new Snacks { Index='j', Name="Twist", Price=20 };

        public static List<Snacks> listOfSnacks = new List<Snacks> // - All products must be stored in one collection only.
        {
            Snickers,
            Mars,
            Twist
        };
    }
}






