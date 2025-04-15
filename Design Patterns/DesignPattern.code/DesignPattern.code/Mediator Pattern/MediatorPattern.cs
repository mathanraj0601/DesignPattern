using DesignPattern.code.Mediator_Pattern.Components;

namespace DesignPattern.code.Mediator_Pattern
{
    public class MediatorPattern
    {
        public void Demo()
        {
            IMediator mediator = new AuctionMediator();
            
            IColleague bidderOne = new Bidder("One", mediator);
            IColleague bidderTwo = new Bidder("Two", mediator);
            IColleague bidderThree = new Bidder("Three", mediator);

            bidderOne.sendBid(100);

        }
    }
}
