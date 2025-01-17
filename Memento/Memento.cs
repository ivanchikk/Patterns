namespace Memento;

public class Memento(string state)
{
    public string State { get; private set; } = state;
}