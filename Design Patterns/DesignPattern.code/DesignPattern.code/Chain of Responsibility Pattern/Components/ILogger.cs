namespace DesignPattern.code.Chain_of_Responsibility_Pattern.Components
{
    public interface ILogger
    {
        public void Log(string message, LogLevel logLevel);
        protected void LogMessage(string message);

    }
}
