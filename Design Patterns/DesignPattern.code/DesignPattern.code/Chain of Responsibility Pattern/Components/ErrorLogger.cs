namespace DesignPattern.code.Chain_of_Responsibility_Pattern.Components
{
    public class ErrorLogger : Logger
    {
        public ErrorLogger(ILogger next) : base(next, LogLevel.ERROR) { }

        public override void LogMessage(string message)
        {
            Console.WriteLine($"[ERROR] : {message}");
        }
    }
}
