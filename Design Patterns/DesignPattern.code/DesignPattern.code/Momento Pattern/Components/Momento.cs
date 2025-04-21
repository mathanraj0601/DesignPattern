namespace DesignPattern.code.Momento_Pattern.Components
{
    public class Momento
    {

        private State state = new();

        public Momento()
        {
        }

        public State GetState()
        {
            return state;
        }

        public void SetState(State state)
        {
            this.state.Value = state.Value;
        }
    }
}
