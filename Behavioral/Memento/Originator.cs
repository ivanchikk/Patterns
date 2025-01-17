using System.Text;

namespace Memento;

public class Originator(string state)
{
    private string _state = state;

    public void Operation()
    {
        Console.WriteLine($"Originator: Initial state '{_state}'");

        _state = GetRandomString();

        Console.WriteLine($"Originator: New state '{_state}'");
    }

    private static string GetRandomString(int length = 10)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var random = new Random();
        var result = new StringBuilder(length);

        for (var i = 0; i < length; i++)
            result.Append(chars[random.Next(chars.Length)]);

        return result.ToString();
    }

    public Memento CreateMemento()
    {
        return new Memento(_state);
    }

    public void SetMemento(Memento memento)
    {
        Console.WriteLine($"Originator: Restoring state '{memento.State}'");
        _state = memento.State;
    }
}