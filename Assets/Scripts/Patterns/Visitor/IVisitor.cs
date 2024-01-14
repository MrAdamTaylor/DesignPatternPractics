namespace Patterns.Visitor
{
    /*public interface IVisitor
    {
        void VisitingCustomer(Customer customer);

        void VisitingEmployee(Employee employee);
    }*/

    public interface IVisitor
    {
        void Visit(IElement element);
    }
}