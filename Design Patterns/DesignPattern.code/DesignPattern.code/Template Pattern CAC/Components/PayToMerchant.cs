namespace DesignPattern.code.Template_Pattern.Components
{
    public class PayToMerchant : PaymentProcess
    {
        protected override void ApplyPlatformFees()
        {
            Console.WriteLine("Apply platform fees for Pay to Merchant");
        }

        protected override void CreditMoney()
        {
            Console.WriteLine("Credit money for Pay to Merchant");
        }

        protected override void DebitMoney()
        {
            Console.WriteLine("Debit Money for Pay to Merchant");
        }

        protected override void Validation()
        {
            Console.WriteLine("Validation for Pay to Merchant");
        }
    }
}
