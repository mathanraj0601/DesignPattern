namespace DesignPattern.code.Observer_Pattern.Components
{
    public class DisplayObservable : IObservable
    {
        private readonly IObserver observer;
        public DisplayObservable(IObserver observer)
        {
            this.observer = observer;
        }
        public void Update()
        {
            Console.WriteLine($" Receiving Messages in Display : {this.observer.getState()}");
        }
    }
}
