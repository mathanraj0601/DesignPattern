namespace DesignPattern.code.Visitor_Pattern.components
{
    public class RoomServiceVisitor : Visitor
    {
        public override void Visit(SingleRoomElement roomElement)
        {
            Console.WriteLine("Single Room : Room Service Visitor");
        }

        public override void Visit(DoubleRoomElement roomElement)
        {
            Console.WriteLine("Double Room : Room Service Visitor");
        }
    }
}
