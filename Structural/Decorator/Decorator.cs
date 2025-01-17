namespace Decorator;

public class Decorator(Component component) : Component
{
    protected Component Component = component;

    public void SetComponent(Component component)
    {
        Component = component;
    }

    public override string Operation()
    {
        return Component.Operation();
    }
}