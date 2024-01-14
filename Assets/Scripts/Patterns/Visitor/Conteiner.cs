using System.Collections.Generic;

namespace Patterns.Visitor
{
    public class Conteiner
    {
        public List<Employee> Employees { get; set; } = new();

        public List<Customer> Customers { get; set; } = new();

        public void Accept(IVisitor visitor)
        {
            foreach (var emplyee in Employees)
            {
                emplyee.Accept(visitor);
            }
        
            foreach (var customer in Customers)
            {
                customer.Accept(visitor);
            }
        }
    }
}