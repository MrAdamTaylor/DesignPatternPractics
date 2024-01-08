using UnityEngine;

namespace Patterns.Flyweight
{
    class CharacterB : ICharacter
    {
        private char _actualChatacter = 'b';
        private string _fontFamily = string.Empty;
        private int _fontSize;
    
        public void Draw(string fontFamily, int fontSize)
        {
            _fontFamily = fontFamily;
            _fontSize = fontSize;
            Debug.Log($"Отрисовка {_actualChatacter}, {_fontFamily} {_fontSize}");
        }
    }
}