namespace ChainOfResponsibility;

class Program
{
    private static void Main(string[] args)
    {
        var h1 = new ConcreteHandler1();
        var h2 = new ConcreteHandler2();
        var h3 = new ConcreteHandler3();

        Console.WriteLine("ConcreteHandler2:\n");
        ClientCode(h2);

        Console.WriteLine("\nConcreteHandler1 => ConcreteHandler2 => ConcreteHandler3:\n");
        h1.SetNext(h2).SetNext(h3);
        ClientCode(h1);
    }

    private static void ClientCode(AbstractHandler handler)
    {
        foreach (var request in _requests)
        {
            Console.WriteLine($"Request: {request}");

            var result = handler.Handle(request);

            if (result != null)
                Console.WriteLine(result);
            else
                Console.WriteLine("No appropriate handler found");

            Console.WriteLine();
        }
    }

    private static List<string> _requests =
    [
        "ConcreteHandler1",
        "ConcreteHandler2",
        "ConcreteHandler3",
        "ConcreteHandler4",
        "ConcreteHandler5"
    ];
}