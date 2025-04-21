namespace DesignPattern.code.Flyweight_Pattern.Components
{
    public class DocumentCharacter : ILetter
    {
        private char character;
        private int fontSize = 0;
        private int x = 0;
        private int y = 0;
        private string fontFamily =  string.Empty;

        public DocumentCharacter(char character)
        {
            this.character = character;
            Console.WriteLine($"{character} is created");
        }

        public void Display(int fontSize, string fontFamily, int x, int y)
        {
            this.fontSize = fontSize;
            this.fontFamily = fontFamily;
            this.x = x;
            this.y = y;
            Console.WriteLine($"Char : {character}, x:{x}, y:{y}, font size:{fontSize}, font family :{fontFamily}");
        }

    }
}
