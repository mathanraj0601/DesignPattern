using DesignPattern.code.Decorator_Pattern.Components;

namespace DesignPattern.code.Decorator_Pattern
{
    public class DecoratorPattern
    {
        public void Demo()
        {

            INotifier basicNotification = new BasicNotification();

            basicNotification = new EmailNotifierDecorator(basicNotification);
            basicNotification = new SlackNotifierDecorator(basicNotification);
            basicNotification = new TeamsNotifierDecorator(basicNotification);

            Console.WriteLine(basicNotification.SendNotification());
        }
    }
}
