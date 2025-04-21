using DesignPattern.code.Strategy_Pattern.Components;

namespace DesignPattern.code.Strategy_Pattern
{
    public class StrategyPattern
    {
        public void Demo()
        {
            Checkout checkout = new Checkout();
            Console.WriteLine(checkout.GetFinalAmount());

            checkout.SetPayAmount(10);
            checkout.SetDiscountStrategy(new LoyaltyDiscountStrategy());
            Console.WriteLine(checkout.GetFinalAmount());

            checkout.SetDiscountStrategy(new VIPDiscountStrategy());
            Console.WriteLine(checkout.GetFinalAmount());
        }
    }
}
