using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrototypeLauncher : DesignPatternLauncher
{
    public override void Launch()
    {
        Debug.Log("Работа паттерна Protorype: ");
        var manager = new Manager("Cindy");
        var managerClone = (Manager)manager.Clone();
        Debug.Log($"Manager was cloned:  { managerClone.Name}");
        

        var employe = new Employe("Kevin", manager);
        var employe2 = new Employe("Derek", managerClone);
        var employeClone = (Employe)employe.Clone(true);
        Debug.Log($"Employe was cloned:  " +
                  $"{ employeClone.Name} with manager {employeClone.Manager.Name}");
        var employeClone2 = (Employe)employe2.Clone(true);
        Debug.Log($"Employe was cloned:  " +
                  $"{ employeClone2.Name} with manager {employeClone2.Manager.Name}");

        //TODO - этот клон поверхностный, поскольку изменение свойста имени приводит к изменению имени во всех остальных типах
        managerClone.Name = "Karen";
        Debug.Log($"Employe was cloned:  " +
                  $"{ employeClone2.Name} with manager {employeClone2.Manager.Name}");
        
    }
}