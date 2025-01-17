namespace Composite;

public class Composite : Component
{
    protected readonly List<Component> Components = [];

    public override string Operation()
    {
        var i = 0;
        var result = "Branch(";

        foreach (var component in Components)
        {
            result += component.Operation();

            if (i < Components.Count - 1)
                result += "+";

            i++;
        }

        return result + ")";
    }

    public override void Add(Component component)
    {
        Components.Add(component);
    }

    public override void Remove(Component component)
    {
        Components.Remove(component);
    }
}