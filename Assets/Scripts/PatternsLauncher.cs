using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternsLauncher : MonoBehaviour
{
    [SerializeField]
    private DesignPatternLauncher[] _patterns;
    

    public void Awake()
    {
        for (int i = 0; i < _patterns.Length; i++)
        {
            _patterns[i].Launch();
        }
    }
}

public abstract class DesignPatternLauncher : MonoBehaviour
{
    public virtual void Launch()
    {
        Debug.Log("Паттерн для тестового запуска не установлен!");
    }
}
