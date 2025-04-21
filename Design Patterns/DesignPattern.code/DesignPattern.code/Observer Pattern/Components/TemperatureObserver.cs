namespace DesignPattern.code.Observer_Pattern.Components
{
    internal class TemperatureObserver : IObserver
    {
        private List<IObservable> observables;
        private int temp = 0;

        public TemperatureObserver()
        {
            observables = new List<IObservable>();
        }
        public int getState()
        {
            return temp;
        }

        public void setState(int value)
        {
            temp = value;
            notifyAllSubscriber();
        }

        public void Subscribe(IObservable observable)
        {
            observables.Add(observable);
        }

        public void UnSubscribe(IObservable observable)
        {
            observables.Remove(observable);
        }

        private void notifyAllSubscriber()
        {
            foreach (var observable in observables)
            {
                observable.Update();
            }
        }
    }
}
