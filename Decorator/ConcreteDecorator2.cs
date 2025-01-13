namespace Decorator;

public class ConcreteDecorator2(Component component) : Decorator(component)
{
    public override string Operation()
    {
        return $"ConcreteDecorator2 {base.Operation()}";
    }
}