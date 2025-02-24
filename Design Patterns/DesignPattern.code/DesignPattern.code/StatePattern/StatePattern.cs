namespace DesignPattern.code.StatePattern
{
    public class StatePattern
    {
        public void Demo()
        {
            IGate gate = new Gate();

            gate.Enter();
            gate.PayFailed();
            gate.PayOK();

            gate.Enter();
            gate.PayFailed();
            gate.PayOK();
        }
    }
}
