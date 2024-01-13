using System;
using System.Threading;
using UnityEngine;
using Random = UnityEngine.Random;

public class Originator 
{
    private string _state;

    public Originator(string state)
    {
        this._state = state;
        Debug.Log("Originator: My initial state is: " + state);
    }

    // The Originator's business logic may affect its internal state.
    // Therefore, the client should backup the state before launching
    // methods of the business logic via the save() method.
    public void DoSomething()
    {
        Debug.Log("Originator: I'm doing something important.");
        this._state = this.GenerateRandomString(30);
        Debug.Log($"Originator: and my state has changed to: {_state}");
    }

    private string GenerateRandomString(int length = 10)
    {
        string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string result = string.Empty;

        while (length > 0)
        {
            result += allowedSymbols[Random.Range(0, allowedSymbols.Length)];

            Thread.Sleep(12);

            length--;
        }

        return result;
    }
    
    public IMemento Save()
    {
        return new ConcreteMemento(this._state);
    }

    // Restores the Originator's state from a memento object.
    public void Restore(IMemento memento)
    {
        if (!(memento is ConcreteMemento))
        {
            throw new Exception("Unknown memento class " + memento.ToString());
        }

        this._state = memento.GetState();
        Console.Write($"Originator: My state has changed to: {_state}");
    }
}