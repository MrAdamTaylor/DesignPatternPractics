using UnityEngine;

namespace Patterns.Visitor
{
    public class VisitorLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Pattern: Visitor");

            var container = new Conteiner();
        
            container.Customers.Add(new Customer("Sad Stalker", 500));
            container.Customers.Add(new Customer("Saharov", 1000));
            container.Customers.Add(new Customer("Eric", 800));
            container.Employees.Add(new Employee("Sidorovich", 20));
            container.Employees.Add(new Employee("Barmen", 15));

            DiscountVisitor discountVisitor = new();
        
            container.Accept(discountVisitor);
        
            Debug.Log($"Total discount: {discountVisitor.TotalDiscountGiven}");
        
            Debug.Log("");
        }
    }
}