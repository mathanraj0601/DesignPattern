using DesignPattern.code.Interpreter_Pattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.code.Interpreter_Pattern
{
    internal class InterpreterPattern 
    {
        public void Demo()
        {
            Context context = new Context();
            context.Add("x", 1);
            context.Add("y", 2);
            IExpression expression = new AddExpression(new NumberExpression("x"), new NumberExpression("y"));
            Console.WriteLine(expression.interpret(context));
        }
    }
}
