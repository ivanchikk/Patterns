namespace Command;

public class ConcreteCommand2(Receiver receiver, string data1, string data2) : ICommand
{
    public void Execute()
    {
        Console.WriteLine($"ConcreteCommand2: command with receiver and data '{data1}, {data2}'");

        receiver.Operation1(data1);
        receiver.Operation2(data2);
    }
}