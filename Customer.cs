using System.Collections.Generic;

namespace VendingMachine
{
    public class Customer
    {
        //private int amountOfMoney = 1000;
        //public int Money { get { return amountOfMoney; } set { amountOfMoney=value; } }
        //Båda ovanståender kod ersattes med nedanstående enkla kod, mycket lättare att förstå!
        public int AmountOfMoney { get; set; } = 0;


        public List<VendingItem> customerPurchazedItems = new List<VendingItem> { };

        public readonly int[] kronorSizes = { 1000, 500, 100, 50, 20, 10, 5, 1 };
        public int[] KronorDenomination()
        {
            int[] counts = { 0, 0, 0, 0, 0, 0, 0, 0 };

            int remainder = AmountOfMoney;
            int sedelCounter = 0;

            while (remainder>0) // 
            {
                counts[sedelCounter]=remainder/kronorSizes[sedelCounter]; // fyll i counts arrayen med t.ex hur många 1000 lappar som får plats i amountOfMoney. I exempel remainder / kronorSizes[sedelCounter] = 1000 / 1000 = 1
                                                                          // alltså blir counter = {1 , 0 ,0 ,0 ,0 ,0 ,0 ,0}
                remainder -= counts[sedelCounter]*kronorSizes[sedelCounter];//remained - (det som tog bort i förra steget, dvs 1000kr).

                sedelCounter++;//sedelCounter++ kolla nästa position
            }
            return counts;
        }
    }
}



