namespace DesignPattern.code.Strategy_Pattern.Components
{
    public class Checkout
    {
        private int price = 0;
        private IDiscountStrategy discountStrategy = new NoDiscountStrategy();
        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        public void SetPayAmount(int price)
        {
            this.price = price;
        }

        public double GetFinalAmount()
        {
            return discountStrategy.ApplyDiscount(this.price);
        }
    }
}
