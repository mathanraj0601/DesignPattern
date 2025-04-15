namespace DesignPattern.code.Template_Pattern.Components
{
    public abstract class PaymentProcess
    {
        protected abstract void Validation();
        protected abstract void DebitMoney();
        protected abstract void ApplyPlatformFees();
        protected abstract void CreditMoney();

        public void sendMoney()
        {
            Validation();
            DebitMoney();
            ApplyPlatformFees();
            CreditMoney();
        }

    }
}
