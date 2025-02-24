namespace DesignPattern.code.TemplatePattern
{
    public class User : Record
    {
        public override void AfterSave()
        {
            Console.WriteLine("After saved");
        }

        public override void BeforeSave()
        {
            Console.WriteLine("Before saved");
        }

        public override void LogInfo()
        {
            Console.WriteLine("User is saved");
        }
    }
}
