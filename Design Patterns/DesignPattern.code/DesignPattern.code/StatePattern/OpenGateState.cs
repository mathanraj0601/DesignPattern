namespace DesignPattern.code.StatePattern
{
    internal class OpenGateState : IGateState
    {
        public IGateState Enter()
        {
            Console.WriteLine("Called open gate state enter");
            return new ClosedGateState();
        }
         
        public IGateState PayFailed()
        {
            Console.WriteLine("Called open gate state enter");
            return new OpenGateState();
        }

        public IGateState PayOK()
        {
            Console.WriteLine("Called open gate state enter");
            return new OpenGateState();
        }
    }
}
