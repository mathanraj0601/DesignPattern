namespace DesignPattern.code.Decorator_Pattern.Components
{
    public class SlackNotifierDecorator : BaseNotifierDecorator
    {
        public SlackNotifierDecorator(INotifier notifier) : base(notifier) { }
        public override string SendNotification()
        {
            return base.SendNotification() + " Via Slack ";
        }
    }
}
