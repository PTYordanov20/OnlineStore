using System;

namespace Exercise.BLL
{
    public interface IPayment
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
        }
    }

    public class PayPalPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}");
        }
    }
}