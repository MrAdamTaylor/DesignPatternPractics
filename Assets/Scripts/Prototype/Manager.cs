using System;

[Serializable]
class Manager : Person
{
    public override string Name { get; set; }

    public Manager(string name)
    {
        Name = name;
    }

    public override Person Clone(bool deepClone = false)
    {
        return (Person)MemberwiseClone();
    }
}