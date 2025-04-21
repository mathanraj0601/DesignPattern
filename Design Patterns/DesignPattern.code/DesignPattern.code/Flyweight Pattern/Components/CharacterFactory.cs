using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.code.Flyweight_Pattern.Components
{
    public class CharacterFactory
    {
        public IDictionary<char, ILetter> documentCharcter;

        public CharacterFactory()
        {
            documentCharcter = new Dictionary<char, ILetter>();
        }

        public ILetter CreateLetter(char letter)
        {
            if (documentCharcter.ContainsKey(letter))
                return documentCharcter[letter];

            ILetter character = new DocumentCharacter(letter);
            documentCharcter.Add(letter, character);
            return character;
        }
    }
}
