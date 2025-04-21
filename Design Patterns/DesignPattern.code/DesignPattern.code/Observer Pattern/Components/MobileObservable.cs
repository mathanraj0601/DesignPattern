namespace DesignPattern.code.Observer_Pattern.Components
{
    internal class MobileObservable : IObservable
    {
        private readonly IObserver observer;
        public MobileObservable(IObserver observer)
        {
            this.observer = observer;
        }
        public void Update()
        {
            Console.WriteLine($" Receiving Messages in Mobile : {this.observer.getState()}");
        }
    }
}
