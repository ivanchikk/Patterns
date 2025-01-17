namespace Memento;

public class Caretaker(Originator originator)
{
    private readonly Stack<Memento> _mementos = [];

    public void Backup()
    {
        Console.WriteLine("Caretaker: Saving Originator's state");
        _mementos.Push(originator.CreateMemento());
    }

    public void Undo()
    {
        if (_mementos.Count == 0) return;

        var memento = _mementos.Pop();

        Console.WriteLine($"Caretaker: Restoring Originator's state to '{memento.State}'");

        originator.SetMemento(memento);
    }

    public void ShowHistory()
    {
        Console.WriteLine("Caretaker: Mementos list");

        foreach (var memento in _mementos)
            Console.WriteLine($"{memento.State}");
    }
}