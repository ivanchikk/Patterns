namespace Visitor;

class Program
{
    private static void Main(string[] args)
    {
        ClientCode(_components, new ConcreteVisitor1());

        Console.WriteLine();

        ClientCode(_components, new ConcreteVisitor2());
    }

    private static void ClientCode(List<IComponent> components, IVisitor visitor)
    {
        foreach (var component in components)
            component.Accept(visitor);
    }

    private static List<IComponent> _components =
    [
        new ConcreteComponent1(),
        new ConcreteComponent2()
    ];
}