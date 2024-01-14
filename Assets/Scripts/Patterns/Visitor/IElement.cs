namespace Patterns.Visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}