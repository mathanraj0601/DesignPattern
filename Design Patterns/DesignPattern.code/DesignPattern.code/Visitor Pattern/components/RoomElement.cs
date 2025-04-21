namespace DesignPattern.code.Visitor_Pattern.components
{
    public abstract class RoomElement
    {
        public abstract void Accept(Visitor visitor);
    }
}
