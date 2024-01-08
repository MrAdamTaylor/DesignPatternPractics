using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Flyweight
{
    public class Paragraph : ICharacter
    {
        private int _location;
        private List<ICharacter> _characters = new();

        public Paragraph(List<ICharacter> characters, int location)
        {
            _characters = characters;
            _location = location;
        }

        public void Draw(string fontFamily, int fontSize)
        {
            Debug.Log($"Drawnig in paragraph at location {_location}");
            foreach (var character in _characters)
            {
                character.Draw(fontFamily, fontSize);
            }
        }
    }
}