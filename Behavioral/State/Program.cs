namespace State;

class Program
{
    private static void Main(string[] args)
    {
        var context = new Context(new ConcreteState3());

        context.Request1();
        Console.WriteLine();

        context.Request2();
        Console.WriteLine();

        context.Request2();
        Console.WriteLine();

        context.Request3();
        Console.WriteLine();
    }
}