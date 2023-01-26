using _25Jan_Lab3.Models;
using System;

namespace _25Jan_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            Market bravo = new ("Bravo");
            Customer customer = new ("Customer", 100)
            {
                VisitedMarket = bravo
            };

            do
            {
                Console.Write("\nEnter command: ");
                command = Console.ReadLine().ToLower().Trim();

                switch (command)
                {
                    case "add item":
                        Console.Write("\nItem name: ");
                        string itemName = Console.ReadLine();

                        Console.Write("Item price: ");
                        double itemPrice = double.Parse(Console.ReadLine());

                        Console.Write("Item quantity: ");
                        int itemQuantity = int.Parse(Console.ReadLine());

                        bravo.AddItem(new Item(itemName, itemPrice, itemQuantity));
                        Console.WriteLine("\nItem added successfully");
                        break;
                    case "show items":
                        bravo.ShowItems();
                        break;
                    case "buy item":
                        Console.Write("\nEnter item id: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Enter item quantity: ");
                        int quantity = int.Parse(Console.ReadLine());

                        customer.BuyItem(id, quantity);
                        break;
                    default:
                        break;
                }
            } while (command != "quit");
        }
    }
}