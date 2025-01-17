namespace FactoryMethod;

class Program
{
    private static void Main(string[] args)
    {
        ClientCode(new ConcreteCreator1());

        Console.WriteLine();

        ClientCode(new ConcreteCreator2());
    }

    private static void ClientCode(Creator creator)
    {
        var product = creator.FactoryMethod();
        Console.WriteLine(product.Operation());
        Console.WriteLine(creator.SomeOperation());
    }
}