namespace Iterator;

public class ConcreteAggregate1<T> : Aggregate<T>
{
    private readonly List<T> _list = [];
    private Iterator<T>? _iterator;

    public override Iterator<T> Iterator
    {
        get => _iterator ?? new ConcreteIterator1<T>(this);
        set => _iterator = value;
    }

    public override void Add(T number)
    {
        _list.Add(number);
    }

    public override int Count
    {
        get => _list.Count;
        protected set { }
    }

    public override T this[int index]
    {
        get => _list[index];
        set => _list[index] = value;
    }
}