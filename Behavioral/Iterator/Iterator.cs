namespace Iterator;

public abstract class Iterator<T>
{
    public abstract bool MoveNext();
    public abstract T Current { get; }
    public abstract void Reset();
}