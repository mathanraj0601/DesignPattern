namespace DesignPattern.code.Bridge_Pattern.Components
{
    public class HumanBreathingImplementor : BreatheImplementor
    {
        public override void breathe()
        {
            Console.WriteLine("Human Breathing Implementor");
        }
    }
}
