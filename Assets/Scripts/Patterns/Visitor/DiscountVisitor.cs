namespace Patterns.Visitor
{
    public class DiscountVisitor : IVisitor
    {
        public float TotalDiscountGiven { get; set; }

        public void Visit(IElement element)
        {
            if (element is Customer)
            {
                VisitingCustomer((Customer)element);
            }
            else if (element is Employee)
            {
                VisitingEmployee((Employee)element);
            }
        }

        private void VisitingCustomer(Customer customer)
        {
            var discount = customer.AmountOrdered / 10;

            customer.Discount = discount;

            TotalDiscountGiven += discount;
        }

        private void VisitingEmployee(Employee employee)
        {
            var discount = employee.YearsEmplyed < 10 ? 100 : 200;

            employee.Discount = discount;

            TotalDiscountGiven += discount;
        }
    }
}