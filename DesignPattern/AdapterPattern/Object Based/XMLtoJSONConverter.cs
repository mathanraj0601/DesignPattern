namespace AdapterPattern.Object_Based
{
    public class XMLtoJSONConverter : IAdapter
    {
        string JsonData;
        public XMLtoJSONConverter(string XmlData) 
        {
            Console.WriteLine("Converting from XML to JSON");
            JsonData = XmlData + "json"; // demo conversion
            
        }
        public void Request()
        {
            AnalyticsTool analyticsTool = new AnalyticsTool();
            analyticsTool.AnalyzeData(JsonData);
        }

    }
}
