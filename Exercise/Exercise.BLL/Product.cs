using System;

namespace Exercise.BLL
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public abstract void DisplayProductDetails();

        public bool CheckStock(int quantity)
        {
            return Stock >= quantity;
        }

        public void DeductStock(int quantity)
        {
            if (CheckStock(quantity))
            {
                Stock -= quantity;
            }
            else
            {
                throw new Exception("Insufficient stock!");
            }
        }
    }

    public class PhysicalProduct : Product
    {
        public PhysicalProduct(string name, decimal price, int stock)
            : base(name, price, stock) { }

        public override void DisplayProductDetails()
        {
            Console.WriteLine($"Physical Product: {Name}, Price: {Price}, Stock: {Stock}");
        }
    }

    public class DigitalProduct : Product
    {
        public DigitalProduct(string name, decimal price, int stock)
            : base(name, price, stock) { }

        public override void DisplayProductDetails()
        {
            Console.WriteLine($"Digital Product: {Name}, Price: {Price}, Stock: Unlimited Downloads");
        }
    }
}