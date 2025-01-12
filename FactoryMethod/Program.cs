namespace FactoryMethod;

class Program
{
    private static void Main(string[] args)
    {
        Creator creator = new ConcreteCreator1();
        var product1 = creator.FactoryMethod();
        Console.WriteLine(product1.Operation());
        Console.WriteLine(creator.SomeOperation());

        Console.WriteLine();

        creator = new ConcreteCreator2();
        var product2 = creator.FactoryMethod();
        Console.WriteLine(product2.Operation());
        Console.WriteLine(creator.SomeOperation());
    }
}