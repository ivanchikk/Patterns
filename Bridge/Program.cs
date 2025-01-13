namespace Bridge;

class Program
{
    private static void Main(string[] args)
    {
        var abstraction = new Abstraction(new ConcreteImplementation1());
        ClientCode(abstraction);

        abstraction.Implementation = new ConcreteImplementation2();
        ClientCode(abstraction);

        abstraction = new ExtendedAbstraction1(new ConcreteImplementation1());
        ClientCode(abstraction);

        abstraction = new ExtendedAbstraction2(new ConcreteImplementation2());
        ClientCode(abstraction);
    }

    private static void ClientCode(Abstraction abstraction)
    {
        Console.WriteLine(abstraction.Operation());
        Console.WriteLine();
    }
}