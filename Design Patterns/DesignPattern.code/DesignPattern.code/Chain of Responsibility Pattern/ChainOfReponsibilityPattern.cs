using DesignPattern.code.Chain_of_Responsibility_Pattern.Components;

namespace DesignPattern.code.Chain_of_Responsibility_Pattern
{
    public class ChainOfReponsibilityPattern
    {
        public void Demo()
        {
            ILogger logger = new ErrorLogger(new DebugLogger(new InfoLogger(null)));

            logger.Log("Error Level", LogLevel.ERROR);
            logger.Log("Debug Level", LogLevel.DEBUG);
            logger.Log("Info Level", LogLevel.INFO);

        }
    }
}
