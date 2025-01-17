namespace Iterator;

public abstract class Aggregate<T>
{
    public abstract Iterator<T> Iterator { get; set; }
    public abstract void Add(T number);
    public abstract int Count { get; protected set; }
    public abstract T this[int index] { get; set; }
}