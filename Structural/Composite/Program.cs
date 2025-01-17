namespace Composite;

class Program
{
    private static void Main(string[] args)
    {
        var leaf = new Leaf();
        ClientCode(leaf);


        var tree = new Composite();

        var branch1 = new Composite();
        branch1.Add(new Leaf());
        branch1.Add(new Leaf());

        var branch2 = new Composite();
        branch2.Add(new Leaf());

        tree.Add(branch1);
        tree.Add(branch2);

        ClientCode(tree);
        ClientCode(tree, leaf);
    }

    private static void ClientCode(Component leaf)
    {
        Console.WriteLine($"RESULT: {leaf.Operation()}\n");
    }

    private static void ClientCode(Component component1, Component component2)
    {
        if (component1.IsComposite())
            component1.Add(component2);

        Console.WriteLine($"RESULT: {component1.Operation()}\n");
    }
}