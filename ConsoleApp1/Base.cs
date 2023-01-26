using _25Jan_Lab3.Models;

namespace _25Jan_Lab3
{
    internal abstract class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Base(string name)
        {
            Name = name;
        }

        protected Item[] IncreaseItemArraySize(Item[] items)
        {
            Item[] newItems = new Item[items.Length + 1];

            for (int i = 0; i < items.Length; i++)
                newItems[i] = items[i];

            return newItems;
        }
    }
}