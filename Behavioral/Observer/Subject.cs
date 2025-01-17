namespace Observer;

public abstract class Subject
{
    private readonly List<IObserver> _observers = [];

    public void Attach(IObserver observer)
    {
        Console.WriteLine($"{GetType().Name}: Observer attached {observer.GetType().Name}");

        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        Console.WriteLine($"{GetType().Name}: Observer detached {observer.GetType().Name}");

        _observers.Remove(observer);
    }

    public void Notify()
    {
        Console.WriteLine($"{GetType().Name}: Notifying observers");

        foreach (var observer in _observers)
            observer.Update(this);
    }
}