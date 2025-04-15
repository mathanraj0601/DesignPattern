namespace DesignPattern.code.Mediator_Pattern.Components
{
    public interface IMediator
    {
        public void AddBidder(IColleague colleague);
        public void Sendbid(IColleague colleague, int bidAmount);
    }
}
