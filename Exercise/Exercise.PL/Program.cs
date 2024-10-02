using System;
using Exercise.BLL;
using Exercise.DAL;

namespace Exercise.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create customer
            Customer customer = CustomerRepository.GetCustomer("John", "Doe");
            customer.DisplayCustomerInfo();

            // Create product
            Product product = ProductRepository.GetProduct("Laptop");
            product.DisplayProductDetails();

            // Create order
            Order order = new Order(customer, product, 2);
            order.ApplyDiscount(new PercentageDiscount(10));  // Apply 10% discount
            order.PaymentMethod = new CreditCardPayment();
            order.ProcessOrder();

            // Check stock and trigger event if out of stock
            StockManager stockManager = new StockManager();
            stockManager.OnStockOut += (p) => Console.WriteLine($"{p.Name} is out of stock!");
            stockManager.CheckStock(product);
        }
    }
}