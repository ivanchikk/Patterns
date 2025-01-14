namespace Command;

public class Invoker
{
    public ICommand? Command1 { private get; set; }
    public ICommand? Command2 { private get; set; }

    public void Operation()
    {
        Console.WriteLine("Invoker: Executing commands");

        Command1?.Execute();
        Console.WriteLine();
        Command2?.Execute();
    }
}