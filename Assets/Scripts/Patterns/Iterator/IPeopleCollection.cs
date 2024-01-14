namespace Patterns.Iterator
{
    public interface IPeopleCollection
    {
        IPeopleIterator CreateIterator();
    }
}