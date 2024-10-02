namespace Exercise.BLL
{
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal price);
    }

    public class FixedDiscount : IDiscount
    {
        public decimal DiscountAmount { get; set; }

        public FixedDiscount(decimal discountAmount)
        {
            DiscountAmount = discountAmount;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return price - DiscountAmount;
        }
    }

    public class PercentageDiscount : IDiscount
    {
        public decimal DiscountPercentage { get; set; }

        public PercentageDiscount(decimal discountPercentage)
        {
            DiscountPercentage = discountPercentage;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return price - (price * DiscountPercentage / 100);
        }
    }
}