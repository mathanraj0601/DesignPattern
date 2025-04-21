namespace DesignPattern.code.Momento_Pattern.Components
{
    public class State
    {
        public int Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
