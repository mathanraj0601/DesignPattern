namespace DesignPattern.code.Bridge_Pattern.Components
{
    public class Human : LivingThingsAbstractor
    {
        public Human(BreatheImplementor breatheImplementor) : base(breatheImplementor)
        {
        }
        public override void breathe()
        {
            _breatheImplementor.breathe();
        }
    }
}
