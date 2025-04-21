namespace DesignPattern.code.Visitor_Pattern.components
{
    public class DoubleRoomElement : RoomElement
    {
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
