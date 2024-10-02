using System;
using Exercise.BLL;
using Exercise.DAL;

namespace Exercise.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = CustomerRepository.GetCustomer("John", "Doe");
            customer.DisplayCustomerInfo();
            
            Product product = ProductRepository.GetProduct("Laptop");
            product.DisplayProductDetails();
            
            Order order = new Order(customer, product, 2);
            order.ApplyDiscount(new PercentageDiscount(10));
            order.PaymentMethod = new CreditCardPayment();
            order.ProcessOrder();
            
            StockManager stockManager = new StockManager();
            stockManager.OnStockOut += (p) => Console.WriteLine($"{p.Name} is out of stock!");
            stockManager.CheckStock(product);
        }
    }
}