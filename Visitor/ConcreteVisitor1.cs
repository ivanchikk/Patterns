namespace Visitor;

public class ConcreteVisitor1 : IVisitor
{
    public void VisitConcreteComponent1(ConcreteComponent1 component)
    {
        Console.WriteLine($"ConcreteVisitor1: Visiting {component.GetType().Name}; Executing: {component.Operation()}");
    }

    public void VisitConcreteComponent2(ConcreteComponent2 component)
    {
        Console.WriteLine($"ConcreteVisitor1: Visiting {component.GetType().Name}; Executing: {component.Operation()}");
    }
}