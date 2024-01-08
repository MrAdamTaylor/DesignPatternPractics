using System;
using UnityEngine;

namespace Patterns.Singleton
{
    public class ThreadSafeLogger
    {
        private static readonly Lazy<ThreadSafeLogger> _threadSafeLogger
            = new Lazy<ThreadSafeLogger>(() => new ThreadSafeLogger());

        
        public static ThreadSafeLogger Instance
        {
            get
            {
                return _threadSafeLogger.Value;
            }
        }

        public void Test()
        {
            Debug.Log("Singlethon Work!");
        }
    }
}