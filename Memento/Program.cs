namespace Memento;

class Program
{
    private static void Main(string[] args)
    {
        var originator = new Originator("state");
        var caretaker = new Caretaker(originator);

        caretaker.Backup();
        originator.Operation();
        Console.WriteLine();

        caretaker.Backup();
        originator.Operation();
        Console.WriteLine();

        caretaker.Backup();
        originator.Operation();
        Console.WriteLine();

        caretaker.ShowHistory();
        Console.WriteLine();

        caretaker.Undo();
        caretaker.Undo();
    }
}