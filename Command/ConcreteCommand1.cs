namespace Command;

public class ConcreteCommand1(string payload) : ICommand
{
    public void Execute()
    {
        Console.WriteLine($"ConcreteCommand1: command without receiver have '{payload}'");
    }
}