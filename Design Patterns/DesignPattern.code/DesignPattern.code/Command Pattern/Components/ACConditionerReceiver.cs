namespace DesignPattern.code.Command_Pattern.Components
{
    public class ACConditionerReceiver
    {
        bool isON;
        int temp;
        public void TurnOn()
        {
            isON = true;
            Console.WriteLine("AC Is Turned on");
        }

        public void TurnOff()
        {
            isON = false;
            Console.WriteLine("AC is turned Off");
        }

        public void SetTemp(int temp)
        {
            this.temp = temp;
            Console.WriteLine($"AC is set to temp : {temp}");
        }

        public int GetTemp()
        {
            return temp;
        }
    }
}
