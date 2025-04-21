namespace DesignPattern.code.Chain_of_Responsibility_Pattern.Components
{
    public abstract class Logger : ILogger
    {
        private readonly LogLevel logLevel;
        private readonly ILogger next;
        public Logger(ILogger next, LogLevel logLevel)
        {
            this.next = next;
            this.logLevel = logLevel;
        }
        public void Log(string message, LogLevel logLevel)
        {
            if (logLevel >= this.logLevel)
                LogMessage(message);
            if (next != null)
                next.Log(message, logLevel);
        }
        public abstract void LogMessage(string message);
        
    }
}
