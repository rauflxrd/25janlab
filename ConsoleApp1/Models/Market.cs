using System;

namespace _25Jan_Lab3.Models
{
    internal class Market : Base
    {
        private static int _id = 1;
        public Item[] Items { get; set; } = new Item[0];

        public Market(string name) : base(name)
        {
            Id = _id++;
        }

        public void AddItem(Item newItem)
        {
            Items = IncreaseItemArraySize(Items);
            Items[^1] = newItem;
        }

        //kohne products [1,2,3]
        //yeni products  [1,2,3,_]

        public void ShowItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Quantity} - ${item.Price}");
            }
        }

        public Item GetItemById(int id)
        {
            foreach (var item in Items)
            {
                if (item.Id == id)
                    return item;
            }

            return new Item("NULL") { Id = -1, Price = -1, Quantity = -1 };
        }
    }
}