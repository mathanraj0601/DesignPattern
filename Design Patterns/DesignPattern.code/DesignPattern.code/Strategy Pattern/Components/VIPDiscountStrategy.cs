namespace DesignPattern.code.Strategy_Pattern.Components
{
    public class VIPDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(int price)
        {
            return price - price * 0.15;
        }
    }
}
