namespace DesignPattern.code.Strategy_Pattern.Components
{
    public class LoyaltyDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(int price)
        {
            return price - price * 0.1;
        }
    }
}
