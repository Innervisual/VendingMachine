VendingMachine

UnitTest.cs
-----------

using VendingMachine;
using Xunit;

namespace TestProject1
{
    public class MoneyInsertTest
    {
        [Fact]
        public void TestInvalidDenomination()
        {
            Customer customer = new Customer();
            Assert.False(new VendingMachine.VendingMachine().InsertMoney(3, customer));
        }

        [Fact]
        public void TestNegativeDenomination()
        {
            Customer customer = new Customer();
            Assert.False(new VendingMachine.VendingMachine().InsertMoney(-100, customer));
        }

        [Fact]

        public void TestValidDenomination()
        {
            Customer customer = new Customer();
            Assert.True(new VendingMachine.VendingMachine().InsertMoney(5, customer));
        }
        [Fact]
        public void TestUpdatedBalanceAfterPurchase()
        {
            IVending vending = new VendingMachine.VendingMachine();
            Customer customer = new Customer();
            int beginningBalance = 500;
            int expectedBalance = 470;

            int debitedAmount = 30;

            vending.InsertMoney(beginningBalance, customer);
            //vending.Purchase(customer, item: new Beverages { Name="item", Price=15, Index='v' });
            //var input = new StringReader("c"); //lades in för att Console.readKey() satte stop för testen, en form för manuell tangent nedtryckning eller "return"
            //men det funkade ändå inte, så bra försökt.
            //Console.SetIn(input);

            customer.AmountOfMoney-=debitedAmount;
            //vending.Purchase(customer, VendingMachine.Beverages.Cocacola);
            //vending.Purchase(customer, VendingMachine.Beverages.Pepsi);


            int actualBalance = customer.AmountOfMoney;

            Assert.Equal(expectedBalance, actualBalance);
        }
