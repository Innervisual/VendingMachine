using System;


namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();



            //int[] resultat = customer.KronorDenomination();
            //foreach (int item in resultat)
            //{
            //    System.Console.WriteLine(item.ToString());
            //}

            IVending vending = new VendingMachine();

            char chosenProduct;
            while (true)
            {


                do
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to this vending machine, what would you like to purchase?");
                    Console.WriteLine("\tInserted amount left: " + customer.AmountOfMoney);
                    Console.WriteLine("Choose product for beverages, food or snacks.");
                    Console.WriteLine();

                    vending.ShowAll();

                    Console.WriteLine("(k) - to insert money.");

                    Console.WriteLine("(l) - to Examine all products.");

                    Console.WriteLine("(q) - to exit vending machine and get change!\n");

                    Console.Write("Input: ");
                    chosenProduct = Console.ReadKey().KeyChar;

                    Console.Write("\nPress enter to continue.");
                    Console.ReadKey();

                } while (chosenProduct !='a' && chosenProduct !='b' && chosenProduct !='c' && chosenProduct !='d' && chosenProduct !='e'
                && chosenProduct !='f' && chosenProduct !='g' && chosenProduct !='h' && chosenProduct !='i' && chosenProduct !='j'
                && chosenProduct != 'k' && chosenProduct != 'l' && chosenProduct != 'q');

                switch (chosenProduct)
                {
                    case 'a':
                        Console.Clear();
                        vending.Purchase(customer, Beverages.Pepsi);
                        break;

                    case 'b':
                        Console.Clear();
                        vending.Purchase(customer, Beverages.Cocacola);
                        break;

                    case 'c':
                        Console.Clear();
                        vending.Purchase(customer, Beverages.Fanta);
                        break;

                    case 'd':
                        Console.Clear();
                        vending.Purchase(customer, Beverages.SevenUp);
                        break;

                    case 'e':
                        Console.Clear();
                        vending.Purchase(customer, Food.Sandwich);
                        break;

                    case 'f':
                        Console.Clear();
                        vending.Purchase(customer, Food.Waffle);
                        break;

                    case 'g':
                        Console.Clear();
                        vending.Purchase(customer, Food.Soup);
                        break;


                    case 'h':
                        Console.Clear();
                        vending.Purchase(customer, Snacks.Snickers);
                        break;

                    case 'i':
                        Console.Clear();
                        vending.Purchase(customer, Snacks.Mars);
                        break;

                    case 'j':
                        Console.Clear();
                        vending.Purchase(customer, Snacks.Twist);
                        break;


                    case 'k':


                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Insert the desired amount of money in kronor and appropiate denomination, press 'q' when done!");

                            Console.Write("Input: ");
                            string amountOfMoneyString = (Console.ReadLine());

                            if (!int.TryParse(amountOfMoneyString, out int amountOfMoneyInserted))
                            {
                                break;
                            }


                            vending.InsertMoney(amountOfMoneyInserted, customer);



                            Console.WriteLine("Customer has inserted this amount: "+ customer.AmountOfMoney);


                            Console.Write("Press enter to continue.");
                            Console.ReadKey();
                            //Lägg till så att man måste addera upp till önskad produkt fullpris


                        }

                        break;

                    case 'l':

                        vending.Examine();

                        break;

                    case 'q':
                        //Här skall det står växel tillbaks och vad man köpt. End Transaction.

                        vending.EndTransaction(customer);

                        break;

                    default:

                        break;

                }
            }
        }
    }
}
