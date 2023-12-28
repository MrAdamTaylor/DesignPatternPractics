using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CharacterFactory
{
    private readonly Dictionary<char, ICharacter> _characters = new();

    [CanBeNull]
    public ICharacter GetCharacter(char characterIdentifier)
    {
        if (_characters.ContainsKey(characterIdentifier))
        {
            Debug.Log("Character reuse: ");
            return _characters[characterIdentifier];
        }
        Debug.Log("Конструкция буквы");

        switch (characterIdentifier)
        {
            case 'a':
                _characters[characterIdentifier] = new CharacterA();
                return _characters[characterIdentifier];
            case 'b':
                _characters[characterIdentifier] = new CharacterB();
                return _characters[characterIdentifier];
        }

        return null;
    }

    public ICharacter CreateParagraph(List<ICharacter> characters, int location)
    {
        return new Paragraph(characters, location);
    }
}