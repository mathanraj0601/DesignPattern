namespace DesignPattern.code.StatePattern
{
    public interface IGate
    {
        public void Enter();
        public void PayFailed();
        public void PayOK();
    }
}
