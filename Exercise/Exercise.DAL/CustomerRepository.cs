using Exercise.BLL;

namespace Exercise.DAL
{
    public static class CustomerRepository
    {
        public static Customer GetCustomer(string firstName, string lastName)
        {
            // In real-world application, this would query a database or API.
            return new Customer(firstName, lastName);
        }
    }
}