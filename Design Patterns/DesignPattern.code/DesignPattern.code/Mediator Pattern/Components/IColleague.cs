namespace DesignPattern.code.Mediator_Pattern.Components
{
    public interface IColleague
    {
        public string GetName();
        public void ReceiveNotification(int bidAmount);
        public void sendBid(int bidAmount);
    }
}
