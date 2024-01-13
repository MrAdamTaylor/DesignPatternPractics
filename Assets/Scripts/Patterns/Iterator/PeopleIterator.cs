using System.Linq;

public class PeopleIterator : IPeopleIterator
{
    private PeopleCollection _peopleCollection;
    private int _current = 0;
    
    public bool IsDone
    {
        get { return _current >= _peopleCollection.Count; }
    }

    public Person CurrentItem { get; }

    public Person CurrentIhem
    {
        get
        {
            return _peopleCollection.
                OrderBy(p => p.Name).ToList()[_current];
        }
    }

    public PeopleIterator(PeopleCollection collection)
    {
        _peopleCollection = collection;
    }

    public Person First()
    {
        _current = 0;
        return _peopleCollection.OrderBy(p => p.Name).ToList()[_current];
    }

    public Person Next()
    {
        _current++;
        if (!IsDone)
        {
            return _peopleCollection.
                OrderBy(p => p.Name).ToList()[_current];
        }
        else
        {
            return null;
        }
    }
}