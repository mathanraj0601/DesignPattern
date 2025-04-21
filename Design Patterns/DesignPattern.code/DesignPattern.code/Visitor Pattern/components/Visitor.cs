namespace DesignPattern.code.Visitor_Pattern.components
{
    public abstract class Visitor
    {
        public abstract void Visit(SingleRoomElement roomElement);
        public abstract void Visit(DoubleRoomElement roomElement);

    }
}
