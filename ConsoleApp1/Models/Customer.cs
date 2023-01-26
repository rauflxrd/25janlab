using System;

namespace _25Jan_Lab3.Models
{
    internal class Customer : Base
    {
        private static int _id = 1;
        public Market VisitedMarket { get; set; }
        public double Balance { get; set; } = 300;
        public Item[] Items { get; set; } = new Item[0];

        public Customer(string name) : base(name)
        {
            Id = _id++;
        }
        public Customer(string name, double balance) : this(name)
        {
            Balance = balance;
        }

        public void BuyItem(int itemId, int quantity)
        {
            Item item = VisitedMarket.GetItemById(itemId);

            if (item.Id == -1)
            {
                Console.WriteLine("\nNo such item in this market");
                return;
            }

            if (item.Quantity == 0)
            {
                Console.WriteLine("\nThis item is out of stock");
                return;
            }

            if (item.Quantity < quantity)
            {
                Console.WriteLine("\nEntered quantity is more than our stock");
                return;
            }

            if (Balance < item.Price * quantity)
            {
                Console.WriteLine("\nYou don't have money to buy this item");
                return;
            }

            item.Quantity -= quantity;
            Balance -= item.Price * quantity;

            PrintReceipt(item, quantity);
        }
        private void PrintReceipt(Item item, int quantity)
        {
            Console.WriteLine($"\n{"Item name",-15} | {"Price",-7} | {"Quantity",-8} | {"Total",-7}");
            Console.WriteLine($"----------------+---------+----------+--------");
            Console.WriteLine($"{item.Name,-15} | {item.Price,-7} | {quantity,-8} | ${item.Price * quantity,-7}");
            Console.WriteLine($"\nYour balance: {Balance}");
        }
    }
}