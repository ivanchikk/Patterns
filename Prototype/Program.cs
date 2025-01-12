namespace Prototype;

class Program
{
    private static void Main(string[] args)
    {
        var p1 = new ConcretePrototype1("string")
        {
            PublicStringProperty1 = "string property1",
            PublicStringProperty2 = "string property2",
            PublicStringProperty3 = "string property3"
        };

        var c1 = p1.Clone() as ConcretePrototype1;
        Console.WriteLine(p1);
        Console.WriteLine(c1);

        Console.WriteLine();

        var p2 = new ConcretePrototype2(12)
        {
            PublicIntProperty1 = 1,
            PublicIntProperty2 = 2,
            PublicIntProperty3 = 3
        };

        var c2 = p2.Clone() as ConcretePrototype2;
        Console.WriteLine(p2);
        Console.WriteLine(c2);
    }
}