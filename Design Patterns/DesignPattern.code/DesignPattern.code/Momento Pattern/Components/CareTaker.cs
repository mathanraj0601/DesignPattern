namespace DesignPattern.code.Momento_Pattern.Components
{
    public class CareTaker
    {

        private Stack<Momento> history = new();

        public void AddMomento(Momento momento)
        {
            history.Push(momento);
        }
        public Momento UndoMomento()
        {
            if (!history.Any())
            {
                return new Momento();
            }
            return history.Pop();
        }

    }
}
