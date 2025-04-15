namespace DesignPattern.code.Mediator_Pattern.Components
{
    internal class Bidder : IColleague
    {
        private string _name;
        IMediator _auctionMediator;
        public Bidder(string name, IMediator auctionMediator)
        {
            _name = name;
            _auctionMediator = auctionMediator;
            _auctionMediator.AddBidder(this);   
        }
        public string GetName()
        {
            return _name;
        }

        public void ReceiveNotification(int bidAmount)
        {
            Console.WriteLine($"Received new Bid price {bidAmount}");
        }

        public void sendBid(int bidAmount)
        {
            _auctionMediator.Sendbid(this, bidAmount);
        }
    }
}
