namespace DesignPattern.code.Adapter_Pattern.Components
{
    public class Adapter : IAdapter
    {
        private readonly Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        // Adapter to connect to the existing system
        public void Request()
        {
            Console.WriteLine("Expected Interface");
            _adaptee.Request();
        }
    }
}
