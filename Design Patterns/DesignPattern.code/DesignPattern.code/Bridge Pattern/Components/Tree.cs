namespace DesignPattern.code.Bridge_Pattern.Components
{
    public class Tree : LivingThingsAbstractor
    {
        public Tree(BreatheImplementor breatheImplementor) : base(breatheImplementor)
        {
        }
        public override void breathe()
        {
            _breatheImplementor.breathe();
        }
    }
}
