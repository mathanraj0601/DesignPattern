using DesignPattern.code.Bridge_Pattern.Components;

namespace DesignPattern.code.Bridge_Pattern
{
    public class BridgePattern
    {
        public void Demo()
        {
            BreatheImplementor humanBreathe = new HumanBreathingImplementor();
            BreatheImplementor treeBreathe = new TreeBreathingImplementor();

            Human human = new Human(humanBreathe);
            Tree tree = new Tree(treeBreathe);

            human.breathe();
            tree.breathe();
        }
    }
}
