namespace DesignPattern.code.Strategy_Pattern.Components
{
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(int price)
        {
            return price;
        }
    }
}
