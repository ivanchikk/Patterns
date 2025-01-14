namespace Strategy;

class Program
{
    private static void Main(string[] args)
    {
        var context = new Context(new ConcreteStrategy1());
        context.Input = "Input";

        Console.WriteLine(context.Operation());

        context.Strategy = new ConcreteStrategy2();

        Console.WriteLine(context.Operation());
    }
}