using DesignPattern.code.Command_Pattern.Components;

namespace DesignPattern.code.Command_Pattern
{
    public class CommandPattern
    {
        public void Demo()
        {
            Invoker invoker = new Invoker();

            invoker.PressButton();
            invoker.UndoButton();

            ACConditionerReceiver aCConditionerReceiver = new ACConditionerReceiver();
            
            invoker.SetCommand(new TurnOnACCommand(aCConditionerReceiver));
            invoker.PressButton();

            invoker.SetCommand(new TurnOffACCommand(aCConditionerReceiver));
            invoker.PressButton();

            invoker.SetCommand(new SetTemperatureACCommand(aCConditionerReceiver,16));
            invoker.PressButton();

            invoker.SetCommand(new SetTemperatureACCommand(aCConditionerReceiver, 24));
            invoker.PressButton();

            invoker.UndoButton();
            invoker.UndoButton();
            invoker.UndoButton();
            invoker.UndoButton();
            invoker.UndoButton();
        }
    }
}
