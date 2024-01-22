using System;

namespace Patterns.Prototype
{
    /// <summary>
    /// Прототип
    /// </summary>
    [Serializable]
    public abstract class Person
    {
        public abstract string Name { get; set; }

        public abstract Person Clone(bool deepClone);
    }
}