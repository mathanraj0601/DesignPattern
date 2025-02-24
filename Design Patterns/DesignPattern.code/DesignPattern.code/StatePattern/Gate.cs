namespace DesignPattern.code.StatePattern
{
    internal class Gate : IGate
    {
        private IGateState _gateState;
        public Gate()
        {
            _gateState = new ClosedGateState();
        }
        public void Enter()
        {
            _gateState = _gateState.Enter();
        }

        public void PayFailed()
        {
            _gateState = _gateState.PayFailed();
        }

        public void PayOK()
        {
            _gateState = _gateState.PayOK();
        }
    }
}
