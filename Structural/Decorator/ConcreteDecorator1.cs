namespace Decorator;

public class ConcreteDecorator1(Component component) : Decorator(component)
{
    public override string Operation()
    {
        return $"ConcreteDecorator1 {base.Operation()}";
    }
}