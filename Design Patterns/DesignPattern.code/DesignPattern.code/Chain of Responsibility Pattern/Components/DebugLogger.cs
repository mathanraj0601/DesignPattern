namespace DesignPattern.code.Chain_of_Responsibility_Pattern.Components
{
    internal class DebugLogger : Logger
    {
        public DebugLogger(ILogger next) : base(next, LogLevel.DEBUG) { }
        public override void LogMessage(string message)
        {
            Console.WriteLine($"[DEBUG] : {message}");
        }
    }
}
