namespace Decorator;

class Program
{
    private static void Main(string[] args)
    {
        var c1 = new ConcreteComponent1();
        ClientCode(c1);

        var d1 = new ConcreteDecorator1(c1);
        ClientCode(d1);

        var d2 = new ConcreteDecorator2(d1);
        ClientCode(d2);

        var c2 = new ConcreteComponent2();
        d1.SetComponent(c2);
        d2.SetComponent(d1);
        ClientCode(d2);
    }

    private static void ClientCode(Component component)
    {
        Console.WriteLine(component.Operation());
    }
}