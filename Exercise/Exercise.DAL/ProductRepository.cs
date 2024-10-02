using Exercise.BLL;

namespace Exercise.DAL
{
    public static class ProductRepository
    {
        public static Product GetProduct(string productName)
        {
            // Simulate fetching a product from a data store.
            if (productName == "Laptop")
            {
                return new PhysicalProduct("Laptop", 1000m, 10);
            }
            else if (productName == "Ebook")
            {
                return new DigitalProduct("Ebook", 50m, int.MaxValue);
            }
            return null;
        }
    }
}