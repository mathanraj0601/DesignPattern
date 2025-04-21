namespace DesignPattern.code.Visitor_Pattern.components
{
    public class AmentitesServiceVisitor : Visitor
    {
        public override void Visit(SingleRoomElement roomElement)
        {
            Console.WriteLine("Single Room : Amentites Service Visitor");
        }

        public override void Visit(DoubleRoomElement roomElement)
        {
            Console.WriteLine("Double Room : Amentites Service Visitor");
        }
    }
}
