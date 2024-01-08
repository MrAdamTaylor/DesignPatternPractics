using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Flyweight
{
    public class FlyweightLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Запущен паттерн flyweight: ");

            var aBunchOfCharacter = "abba";
            var characterFactory = new CharacterFactory();

            var characterObject = characterFactory.GetCharacter(aBunchOfCharacter[0]);
            characterObject?.Draw("Arail", 12);

            characterObject = characterFactory.GetCharacter(aBunchOfCharacter[1]);
            characterObject?.Draw("Trebuchet MS", 14);

            characterObject = characterFactory.GetCharacter(aBunchOfCharacter[2]);
            characterObject?.Draw("Times New Roman", 16);

            characterObject = characterFactory.GetCharacter(aBunchOfCharacter[3]);
            characterObject?.Draw("Comic Sans", 10);

            var paragraph = characterFactory.CreateParagraph(new List<ICharacter>() { characterObject }, 1);
            paragraph.Draw("Lucinda", 12);
        }
    }
}