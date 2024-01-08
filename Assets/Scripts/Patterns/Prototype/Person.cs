using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

    [Serializable]
    class Employe : Person
    {
        public Manager Manager { get; set; }
        public override string Name { get; set; }

        public Employe(string name, Manager manager)
        {
            Name = name;
            Manager = manager;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var formatter = new BinaryFormatter();
                using (var strem = new MemoryStream())
                {
                    #region NotSecurityCode

                    formatter.Serialize(strem, this);
                    strem.Seek(0, SeekOrigin.Begin);
                    return (Person)formatter.Deserialize(strem);
                    //TODO - метод Deserialize может быть использован злоумышленником, 
                    //TODO - к примеру выполнить атаку "Отказ в обслуживании"
                    #endregion
                
                }
            }
            return (Person)MemberwiseClone();
        }
    }
}