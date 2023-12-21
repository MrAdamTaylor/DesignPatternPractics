using UnityEngine;

namespace FactoryMethod
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