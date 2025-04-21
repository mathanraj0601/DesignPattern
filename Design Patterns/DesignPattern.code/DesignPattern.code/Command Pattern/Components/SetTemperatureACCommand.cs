namespace DesignPattern.code.Command_Pattern.Components
{
    internal class SetTemperatureACCommand : ICommand
    {
        ACConditionerReceiver _acConditionerReceiver;
        int _temp;
        int _previousTemp;
        public SetTemperatureACCommand(ACConditionerReceiver aCConditionerReceiver, int temp)
        {
            _acConditionerReceiver = aCConditionerReceiver;
            _temp = temp;
            _previousTemp = _acConditionerReceiver.GetTemp();
        }
        public void Execute()
        {
            _acConditionerReceiver.SetTemp(_temp);
        }

        public void UnExecute()
        {
            _acConditionerReceiver.SetTemp(_previousTemp);
        }
    }
}
