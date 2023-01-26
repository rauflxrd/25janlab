namespace _25Jan_Lab3.Models
{
    internal class Item : Base
    {
        private static int _id = 1;
        public int Quantity { get; set; } = 1;
        public double Price { get; set; }

        public Item(string name) : base(name)
        {
            Id = _id++;
        }
        public Item(string name, double price, int quantity) : this(name)
        {
            Price = price;
            Quantity = quantity;
        }
    }
}