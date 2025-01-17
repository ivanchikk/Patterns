namespace Mediator;

class Program
{
    private static void Main(string[] args)
    {
        var c1 = new ConcreteColleague1();
        var c2 = new ConcreteColleague2();
        var m = new ConcreteMediator(c1, c2);

        c1.Operation1();

        Console.WriteLine();

        c2.Operation1();
    }
}