namespace AbstractFactory;

class Program
{
    private static void Main(string[] args)
    {
        ClientCode(new ConcreteFactory1());

        Console.WriteLine();

        ClientCode(new ConcreteFactory2());
    }

    private static void ClientCode(IAbstractFactory factory)
    {
        var productA = factory.CreateProductA();
        var productB = factory.CreateProductB();
        Console.WriteLine(productA.OperationA());
        Console.WriteLine(productB.OperationB());
    }
}