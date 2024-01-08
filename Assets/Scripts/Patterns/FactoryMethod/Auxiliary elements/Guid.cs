using UnityEngine;

namespace Patterns.FactoryMethod.Auxiliary_elements
{
    public class Guid
    {
        public static Guid NewGuid()
        {
            Guid guid = new Guid();
            Debug.Log("Код создался!");
            return guid;
        }
    }
}