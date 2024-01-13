using System;
using System.Collections;
using Patterns;
using UnityEngine;

public class IteratorLauncher : DesignPatternLauncher
{
    public override void Launch()
    {
        Debug.Log("Запуск паттерна Iterator");

        PeopleCollection people = new();
        
        people.Add(new Person("Christina Constaza", "USA"));
        people.Add(new Person("Ogyzok", "Russia"));
        people.Add(new Person("Olehandro Rohas", "Brazil"));
        people.Add(new Person("Hex", "China"));

        var peopleIteratro = people.CreateIterator();

        for (Person person = peopleIteratro.First();
             !peopleIteratro.IsDone;
             person = peopleIteratro.Next())
        {
            Debug.Log(person?.Name);
        }
        Debug.Log("");
    }
}