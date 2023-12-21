using System.Collections;
using System.Collections.Generic;
using Builder;
using UnityEngine;

public class BuilderLauncher : DesignPatternLauncher
{
    public override void Launch()
    {
        Debug.Log("Работа паттерна Builder: ");
        var garage = new Garage();

        var miniBuilder = new MiniBuilder();
        var bmwBuilder = new BMWBuilder();
        
        garage.Construct(miniBuilder);
        miniBuilder.Car.Output();
        
        garage.Construct(bmwBuilder);
        bmwBuilder.Car.Output();
    }
}
