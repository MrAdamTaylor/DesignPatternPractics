using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{
    private readonly List<string> _parts = new();
    private readonly string _carType;

    public Car(string carType)
    {
        _carType = carType;
    }

    public void AddPart(string part)
    {
        _parts.Add(part);
    }

    public void Output()
    {
        foreach (string part in _parts)
        {
            Debug.Log($"Car of type {_carType} has part {part}.");
        }
    }
}
