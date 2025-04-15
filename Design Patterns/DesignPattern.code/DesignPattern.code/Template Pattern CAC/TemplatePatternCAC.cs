using DesignPattern.code.Template_Pattern.Components;

namespace DesignPattern.code.Template_Pattern
{
    public class TemplatePatternCAC
    {
        public void Demo()
        {
            PaymentProcess paymentProcessFriend = new PayToFriend();
            paymentProcessFriend.sendMoney();
            PaymentProcess paymentProcessMerchant = new PayToMerchant();
            paymentProcessMerchant.sendMoney();
        }
    }
}
