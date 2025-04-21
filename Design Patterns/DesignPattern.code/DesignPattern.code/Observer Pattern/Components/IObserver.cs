namespace DesignPattern.code.Observer_Pattern.Components
{
    public interface IObserver
    {
        public void Subscribe(IObservable observable);
        public void UnSubscribe(IObservable observable);
        public void setState(int value);
        public int getState();
    }
}
