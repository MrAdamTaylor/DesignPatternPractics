using System;

public interface IMemento
{
    string GetName();

    string GetState();

    DateTime GetDate();
}