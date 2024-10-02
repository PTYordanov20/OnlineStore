using System;

namespace Exercise.BLL
{
    public class Order
    {
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public IDiscount Discount { get; set; }
        public IPayment PaymentMethod { get; set; }

        public Order(Customer customer, Product product, int quantity)
        {
            Customer = customer;
            Product = product;
            Quantity = quantity;
        }

        public void ApplyDiscount(IDiscount discount)
        {
            Discount = discount;
        }

        public void ProcessOrder()
        {
            if (!Product.CheckStock(Quantity))
            {
                throw new Exception("Not enough stock to fulfill the order.");
            }

            Product.DeductStock(Quantity);
            decimal total = Product.Price * Quantity;
            if (Discount != null)
            {
                total = Discount.ApplyDiscount(total);
            }

            Console.WriteLine($"Total price after discount: {total}");
            PaymentMethod?.ProcessPayment(total);

            if (Product is PhysicalProduct)
            {
                Console.WriteLine("Shipping the product...");
            }
            else if (Product is DigitalProduct)
            {
                Console.WriteLine("Sending download link...");
            }
        }
    }
}