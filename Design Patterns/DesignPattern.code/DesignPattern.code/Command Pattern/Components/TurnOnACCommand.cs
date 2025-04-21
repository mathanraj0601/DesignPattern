namespace DesignPattern.code.Command_Pattern.Components
{
    public class TurnOnACCommand : ICommand
    {
        ACConditionerReceiver _aCConditionerReceiver1;
        public TurnOnACCommand(ACConditionerReceiver aCConditionerReceiver)
        {
            _aCConditionerReceiver1 = aCConditionerReceiver;
        }
        public void Execute()
        {
            _aCConditionerReceiver1.TurnOn();
        }

        public void UnExecute()
        {
            _aCConditionerReceiver1.TurnOff();
        }
    }
}
