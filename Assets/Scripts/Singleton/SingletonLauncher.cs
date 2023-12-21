using UnityEngine;

namespace Singleton
{
    
    
    public class SingletonLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Паттерн синглтон: ");
            Logger.Instance.Test();
        }
    }
}