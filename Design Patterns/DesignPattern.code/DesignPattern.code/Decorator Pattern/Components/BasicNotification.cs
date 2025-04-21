namespace DesignPattern.code.Decorator_Pattern.Components
{
    public class BasicNotification : INotifier
    {
        public string SendNotification()
        {
            return "Send Basic Notification";
        }
    }
}
