namespace DesignPattern.code.Decorator_Pattern.Components
{
    public class EmailNotifierDecorator : BaseNotifierDecorator
    {
        public EmailNotifierDecorator(INotifier notifier) : base(notifier) { }
        public override string SendNotification()
        {
            return base.SendNotification() + "sVia Email ";
        }
    }
}
