namespace DesignPattern.code.Momento_Pattern.Components
{
    public class Originator
    {
        public State state { get; set; } = new();

        public Originator()
        {
            state = new();
        }

        public void RestoreState(Momento momento)
        {
            this.state = momento.GetState();
        }

        public Momento createMomento()
        {
            var momento = new Momento();
            momento.SetState(state);
            return momento;
        }
    }
}
