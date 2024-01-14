using UnityEngine;

namespace Patterns.Visitor
{
    public class Customer : IElement
    {
        public float AmountOrdered { get; private set; }

        public float Discount { get; set; }

        public string Name { get; private set; }

        public Customer(string name, float amountOrdered)
        {
            Name = name;
            AmountOrdered = amountOrdered;
        }

        public void Accept(IVisitor visitor)
        {
            //visitor.VisitingCustomer(this);
            visitor.Visit(this);
            Debug.Log($"Visited {nameof(Customer)} {Name}, discount given: {Discount}");
        }
    }
}