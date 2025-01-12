namespace Builder;

class Program
{
    private static void Main(string[] args)
    {
        var b1 = new ConcreteBuilder1();
        var director = new Director(b1);

        director.BuildMinimal();
        Console.WriteLine("Minimal:\n" + b1.Build().ListParts());

        director.BuildFull();
        Console.WriteLine("Full:\n" + b1.Build().ListParts());

        Console.WriteLine();

        var b2 = new ConcreteBuilder2();
        director.Builder = b2;

        director.BuildMinimal();
        Console.WriteLine("Minimal:\n" + b2.Build().ListParts());

        director.BuildFull();
        Console.WriteLine("Full:\n" + b2.Build().ListParts());

        Console.WriteLine();

        var b3 = new ConcreteBuilder1();
        b3.AddA();
        b3.AddB();
        Console.WriteLine("Custom:\n" + b3.Build().ListParts());
    }
}