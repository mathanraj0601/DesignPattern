using DesignPattern.code.Adapter_Pattern.Components;

namespace DesignPattern.code.Adapter_Pattern
{
    public class AdapterPattern
    {
        public void Demo()
        {
            Adaptee adaptee = new Adaptee();
            IAdapter adapter = new Adapter(adaptee);
            adapter.Request();
        }
    }
}
