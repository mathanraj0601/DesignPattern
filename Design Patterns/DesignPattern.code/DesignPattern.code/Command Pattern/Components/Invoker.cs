namespace DesignPattern.code.Command_Pattern.Components
{
    public class Invoker
    {
        Stack<ICommand> _commands;
        ICommand _command;

        public Invoker()
        {
            _commands = new Stack<ICommand>();
            _command = new NullCommand();
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
            _commands.Push(_command);
        }

        public void UndoButton()
        {
            if(_commands.Count > 0)
            {
                _commands.Pop().UnExecute();
            }
        }
    }
}
