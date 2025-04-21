using DesignPattern.code.Visitor_Pattern.components;

namespace DesignPattern.code.Visitor_Pattern
{
    public class VisitorPattern
    {
        public void Demo()
        {
            RoomServiceVisitor roomServiceVisitor = new RoomServiceVisitor();
            AmentitesServiceVisitor amentitesServiceVisitor = new AmentitesServiceVisitor();

            RoomElement singleElement = new SingleRoomElement();
            RoomElement doubleElement = new DoubleRoomElement();

            singleElement.Accept(roomServiceVisitor);
            singleElement.Accept(amentitesServiceVisitor);

            doubleElement.Accept(roomServiceVisitor);
            doubleElement.Accept(amentitesServiceVisitor);
        }
    }
}
