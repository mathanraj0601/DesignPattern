namespace DesignPattern.code.Chain_of_Responsibility_Pattern.Components
{
    public class InfoLogger : Logger
    {
        public InfoLogger(ILogger next) : base(next, LogLevel.INFO) { }
        public override void LogMessage(string message)
        {
            Console.WriteLine($"[INFO] : {message}");
        }
    }
}
