namespace Iterator;

public class ConcreteAggregate2 : Aggregate<int>
{
    private readonly List<int> _numbers = [];
    private Iterator<int>? _iterator;

    public override Iterator<int> Iterator
    {
        get => _iterator ?? new ConcreteIterator1<int>(this);
        set => _iterator = value;
    }

    public override void Add(int type)
    {
        _numbers.Add(type);
    }

    public override int Count
    {
        get => _numbers.Count;
        protected set { }
    }

    public override int this[int index]
    {
        get => _numbers[index];
        set => _numbers[index] = value;
    }
}