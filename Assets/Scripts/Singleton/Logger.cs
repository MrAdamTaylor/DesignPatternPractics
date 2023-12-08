using JetBrains.Annotations;
using UnityEngine;

namespace Singleton
{
    public class Logger 
    {
        [CanBeNull] private static Logger _instance;

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        public void Test()
        {
            Debug.Log("Singlethon Work!");
        }
    }
}