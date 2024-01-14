using UnityEngine;

namespace Patterns.Visitor
{
    public class Employee : IElement
    {
        public float YearsEmplyed { get; private set; }

        public float Discount { get; set; }

        public string Name { get; private set; }

        public Employee(string name, float amountOrdered)
        {
            Name = name;
            YearsEmplyed = amountOrdered;
        }

        public void Accept(IVisitor visitor)
        {
            //visitor.VisitingEmployee(this);
            visitor.Visit(this);
            Debug.Log($"Visited {nameof(Employee)} {Name}, discount given: {Discount}");
        }
    }
}