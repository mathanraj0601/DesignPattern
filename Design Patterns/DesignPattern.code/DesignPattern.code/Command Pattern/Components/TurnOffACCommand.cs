namespace DesignPattern.code.Command_Pattern.Components
{
    internal class TurnOffACCommand : ICommand
    {
        ACConditionerReceiver _acConditionerReceiver;
        public TurnOffACCommand(ACConditionerReceiver aCConditionerReceiver)
        {
            _acConditionerReceiver = aCConditionerReceiver;
        }
        public void Execute()
        {
            _acConditionerReceiver.TurnOff();
        }

        public void UnExecute()
        {
            _acConditionerReceiver.TurnOn();
        }
    }
}
