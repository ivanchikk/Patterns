namespace Iterator;

public class ConcreteIterator2<T>(Aggregate<T> aggregate) : Iterator<T>
{
    private int _position = aggregate.Count;

    public override bool MoveNext()
    {
        var next = _position - 1;

        if (next >= 0 && next < aggregate.Count)
        {
            _position = next;
            return true;
        }

        return false;
    }

    public override T Current
    {
        get
        {
            if (_position >= 0 && _position < aggregate.Count)
                return aggregate[_position];

            throw new IndexOutOfRangeException();
        }
    }

    public override void Reset()
    {
        _position = aggregate.Count - 1;
    }
}