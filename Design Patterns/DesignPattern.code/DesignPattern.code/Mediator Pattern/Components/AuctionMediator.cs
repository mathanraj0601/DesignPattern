namespace DesignPattern.code.Mediator_Pattern.Components
{
    internal class AuctionMediator : IMediator
    {
        List<IColleague> colleagueList;
        public AuctionMediator()
        {
            colleagueList = new List<IColleague>();
        }
        public void AddBidder(IColleague colleague)
        {
            colleagueList.Add(colleague);
        }

        public void Sendbid(IColleague colleague, int bidAmount)
        {
            foreach(var col in colleagueList)
            {
                if (!colleague.GetName().Equals(col.GetName()))
                {
                    col.ReceiveNotification(bidAmount);
                }
            }
        }
    }
}
