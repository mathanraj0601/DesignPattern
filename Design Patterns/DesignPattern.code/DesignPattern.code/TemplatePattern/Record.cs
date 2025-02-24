namespace DesignPattern.code.TemplatePattern
{
    public abstract class Record
    {
       public virtual void LogInfo()
       {
           /// do nothing
       }
        public abstract void BeforeSave();
        public abstract void AfterSave();
        public void Save()
        {
            BeforeSave();
            LogInfo();
            AfterSave();
        }

    }
}
