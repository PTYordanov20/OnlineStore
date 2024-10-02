namespace Exercise.BLL
{
    public class StockManager
    {
        public delegate void StockOutHandler(Product product);
        public event StockOutHandler OnStockOut;

        public void CheckStock(Product product)
        {
            if (product.Stock == 0)
            {
                OnStockOut?.Invoke(product);
            }
        }
    }
}