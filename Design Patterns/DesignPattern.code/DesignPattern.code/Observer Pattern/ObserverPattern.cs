using DesignPattern.code.Observer_Pattern.Components;

namespace DesignPattern.code.Observer_Pattern
{
    public class ObserverPattern
    {
        public void Demo()
        {
            IObserver observer = new TemperatureObserver();
            IObservable displayObservable = new DisplayObservable(observer);
            IObservable mobileObservable = new MobileObservable(observer);

            observer.Subscribe(displayObservable);
            observer.Subscribe(mobileObservable);

            observer.setState(100);

            observer.UnSubscribe(displayObservable);

            observer.setState(10);
        }
    }
}
