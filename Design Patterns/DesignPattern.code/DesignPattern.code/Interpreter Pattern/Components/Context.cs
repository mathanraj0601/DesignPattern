namespace DesignPattern.code.Interpreter_Pattern.Components
{
    public class Context
    {
        Dictionary<string, int> keyValues;

        public Context()
        {
            keyValues = new Dictionary<string, int>();
        }

        public void Add(string key, int value)
        {
            if(!keyValues.ContainsKey(key))
                keyValues.Add(key, value);
            keyValues[key] = value;
        }
        public int Get(string key)
        {
            if (keyValues.ContainsKey(key))
            {
                return keyValues[key];
            }
            return 0;
        }
    }
}
