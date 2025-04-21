namespace DesignPattern.code.Visitor_Pattern.components
{
    public class SingleRoomElement : RoomElement
    {
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
