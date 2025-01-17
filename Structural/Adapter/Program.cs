namespace Adapter;

class Program
{
    private static void Main(string[] args)
    {
        var adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);

        // Adaptee interface is incompatible with the client.
        // But with adapter client can call its method.

        Console.WriteLine(target.GetRequest());
    }
}