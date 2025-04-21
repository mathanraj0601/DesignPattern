namespace DesignPattern.code.Interpreter_Pattern.Components
{
    public class NumberExpression : IExpression
    {
        private string value;
        public NumberExpression(string value)
        {
            this.value = value;
        }
        public int interpret(Context context)
        {
            return context.Get(value);
        }
    }
}
