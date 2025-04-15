namespace DesignPattern.code.Template_Pattern.Components
{
    public class PayToFriend : PaymentProcess
    {
        protected override void ApplyPlatformFees()
        {
            Console.WriteLine("Apply platform fees for Pay to friend");
        }

        protected override void CreditMoney()
        {
            Console.WriteLine("Credit money for Pay to friend");
        }

        protected override void DebitMoney()
        {
            Console.WriteLine("Debit Money for Pay to friend");
        }

        protected override void Validation()
        {
            Console.WriteLine("Validation for Pay to friend");
        }
    }
}
