namespace DesignPattern.code.Interpreter_Pattern.Components
{
    public class AddExpression : IExpression
    {
        private IExpression left;
        private IExpression right;

        public AddExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;   
        }
        public int interpret(Context context)
        {
            return left.interpret(context) + right.interpret(context);
        }
    }
}
