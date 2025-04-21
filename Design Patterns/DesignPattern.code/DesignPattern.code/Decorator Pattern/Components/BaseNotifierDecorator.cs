namespace DesignPattern.code.Decorator_Pattern.Components
{
    public class BaseNotifierDecorator : INotifier
    {
        private readonly INotifier notifier;
        public BaseNotifierDecorator(INotifier notifier)
        {
            this.notifier =  notifier;
        }

        public virtual string SendNotification()
        {
            return notifier.SendNotification();
        }
    }
}
