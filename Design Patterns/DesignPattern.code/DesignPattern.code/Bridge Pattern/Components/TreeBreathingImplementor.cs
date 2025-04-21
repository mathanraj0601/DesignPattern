namespace DesignPattern.code.Bridge_Pattern.Components
{
    internal class TreeBreathingImplementor : BreatheImplementor
    {
        public override void breathe()
        {
            Console.WriteLine("Tree Breathing Implementor");
        }
    }
}
