namespace Command;

class Program
{
    private static void Main(string[] args)
    {
        var invoker = new Invoker();
        var receiver = new Receiver();

        invoker.Command1 = new ConcreteCommand1("payload");
        invoker.Command2 = new ConcreteCommand2(receiver, "data1", "data2");

        invoker.Operation();
    }
}