using Exercise.BLL;

namespace Exercise.DAL
{
    public static class CustomerRepository
    {
        public static Customer GetCustomer(string firstName, string lastName)
        {
            return new Customer(firstName, lastName);
        }
    }
}