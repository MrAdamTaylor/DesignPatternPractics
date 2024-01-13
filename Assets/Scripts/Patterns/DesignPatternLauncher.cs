using UnityEngine;

namespace Patterns
{
    public abstract class DesignPatternLauncher : MonoBehaviour
    {
        public virtual void Launch()
        {
            Debug.Log("Паттерн для тестового запуска не установлен!");
        }
    }
}