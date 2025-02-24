namespace DesignPattern.code.StatePattern
{
    public interface IGateState
    {
        public IGateState Enter();
        public IGateState PayFailed();
        public IGateState PayOK();
    }
}
