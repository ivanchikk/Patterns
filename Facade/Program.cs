namespace Facade;

class Program
{
    private static void Main(string[] args)
    {
        var s1 = new Subsystem1();
        var s2 = new Subsystem2();
        var facade = new Facade(s1, s2);

        ClientCode(facade);
    }

    private static void ClientCode(Facade facade)
    {
        Console.WriteLine(facade.Operation1());
        Console.WriteLine();
        Console.WriteLine(facade.Operation2());
    }
}