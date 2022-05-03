using System;
using System.Linq;

namespace VendingMachine
{
    public abstract class VendingItem
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public char Index { get; set; }

    }

    public interface IVending
    {
        public void ShowAll();

        public bool InsertMoney(int amount, Customer customer);

        public void Purchase(Customer customer, VendingItem item);
        public void EndTransaction(Customer customer);
        public void Examine();
    }

    public class VendingMachine : IVending
    {
        public void ShowAll()
        {
            Console.WriteLine("Beverages:");
            foreach (Beverages drink in Beverages.listOfBeverages)
            {
                Console.WriteLine($"\t({drink.Index}) {drink.Name} costs {drink.Price}kr.");
            }


            Console.WriteLine("\nFood:");
            foreach (Food food in Food.listOfFood)
            {
                Console.WriteLine($"\t({food.Index}) {food.Name} costs {food.Price}kr.");
            }


            Console.WriteLine("\nSnacks:");
            foreach (Snacks snack in Snacks.listOfSnacks)
            {
                Console.WriteLine($"\t({snack.Index}) {snack.Name} costs {snack.Price}kr.");
            }
            Console.WriteLine();

        }
        public bool InsertMoney(int amount, Customer customer)
        {
            if (customer.kronorSizes.Contains(amount))
            {
                customer.AmountOfMoney+=amount;
                return true;
            }

            Console.WriteLine("Invalid denomination! Please insert valid denomination.");

            return false;


        }

        public void Purchase(Customer customer, VendingItem item)
        {

            if (customer.AmountOfMoney-item.Price<0)
            {
                Console.WriteLine("Please insert more livesaving money money money!");
                Console.Write("\nPress enter to continue.");
                Console.ReadKey();

            }

            else
            {
                customer.AmountOfMoney-=item.Price;
                customer.customerPurchazedItems.Add(item);
                Use(item);

            }

        }

        public void EndTransaction(Customer customer)
        {
            Console.Clear();

            Console.WriteLine("Here are your purchaced products:");


            foreach (VendingItem item in customer.customerPurchazedItems)
            {
                Console.WriteLine("\t"+item.Name);
            }

            int[] changeArray = customer.KronorDenomination();
            Console.WriteLine("\nHere is your change:");

            for (int i = 0; i < changeArray.Length; i++)
            {
                if (changeArray[i]!=0)
                {
                    Console.WriteLine($"\t{changeArray[i]} x {customer.kronorSizes[i]} bills");
                }
            }

            Console.Write("\nPress enter to Exit.");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public void Examine()
        {
            Console.Clear();
            Console.WriteLine("All product information:");
            foreach (Beverages drink in Beverages.listOfBeverages)
            {
                Console.WriteLine($"\t{drink.Name} is a drink, costs {drink.Price} kr and has index ({drink.Index})");
            }

            foreach (Food food in Food.listOfFood)
            {
                Console.WriteLine($"\t{food.Name} is a food, costs {food.Price} kr and has index ({food.Index})");
            }

            foreach (Snacks snack in Snacks.listOfSnacks)
            {
                Console.WriteLine($"\t{snack.Name} is a snack, costs {snack.Price} kr and has index ({snack.Index})");
            }

            Console.Write("\nPress enter to continue.");
            Console.ReadKey();

        }
        public void Use(VendingItem item)
        {
            if (item.GetType()==typeof(Beverages))
            {
                Console.WriteLine($"Please drink the {item.Name}.");
            }
            else if (item.GetType()==typeof(Food))
            {
                Console.WriteLine($"Please heat the {item.Name} before consuming.");
            }
            else if (item.GetType()==typeof(Snacks))
            {
                Console.WriteLine($"Please eat the {item.Name}.");

            }
            else
            {
                Console.WriteLine("Product couldn't be found!");
            }
            Console.Write("\nPress enter to continue.");
            Console.ReadKey();

        }
    }
}




