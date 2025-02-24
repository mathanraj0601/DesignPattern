namespace DesignPattern.code.StatePattern
{
    public class ClosedGateState : IGateState
    {
        public IGateState Enter()
        {
            Console.WriteLine("Called closed gate state enter");
            return new ClosedGateState();
        }

        public IGateState PayFailed()
        {
            Console.WriteLine("Called closed gate state pay failed");
            return new ClosedGateState();
        }

        public IGateState PayOK()
        {
            Console.WriteLine("Called closed gate state pay ok");
            return new OpenGateState();
        }
    }
}
