namespace TemplateMethod;

class Program
{
    private static void Main(string[] args)
    {
        ClientCode(new ConcreteClass1());

        Console.WriteLine();

        ClientCode(new ConcreteClass2());
    }

    private static void ClientCode(AbstractClass abstractClass)
    {
        abstractClass.TemplateMethod();
    }
}