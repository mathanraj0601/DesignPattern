namespace AdapterPattern.Class_Based
{
    public class XMLtoJSONConverter : AnalyticsTool , IAdapter
    {
        string JsonData;
        public XMLtoJSONConverter(string XmlData) 
        {
            Console.WriteLine("Converting from XML to JSON");
            JsonData = XmlData + "json"; // demo conversion
            
        }
        public void Request()
        {
            this.AnalyzeData(JsonData);
        }

    }
}
