namespace AdapterPattern.Class_Based
{
    // Adaptee
    public class AnalyticsTool
    {
        public void AnalyzeData(String JsonData)
        {
            if (JsonData.EndsWith("json"))
                Console.WriteLine("Analyzing Json Data");
            else 
                Console.WriteLine("Incompatible Data ");
        }
    }
}
