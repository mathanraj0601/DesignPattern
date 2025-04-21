using DesignPattern.code.Flyweight_Pattern.Components;

namespace DesignPattern.code.Flyweight_Pattern
{
    public class FlyWeightPattern
    {
        public void Demo()
        {
            CharacterFactory characterFactory = new CharacterFactory();
            for(int i =0; i < 100; i++)
            {
                var ch = characterFactory.CreateLetter((char)((i % 26) + 65));
                ch.Display(12,"Sans seriff", i ,i);
            }
        }
    }
}
