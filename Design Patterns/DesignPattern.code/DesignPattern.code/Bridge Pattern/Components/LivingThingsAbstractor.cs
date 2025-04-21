namespace DesignPattern.code.Bridge_Pattern.Components
{
    public abstract class LivingThingsAbstractor
    {
        protected BreatheImplementor _breatheImplementor;
        protected LivingThingsAbstractor(BreatheImplementor breatheImplementor)
        {
            _breatheImplementor = breatheImplementor;
        }
        public abstract void breathe();
    }
}
