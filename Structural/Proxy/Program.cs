namespace Proxy;

class Program
{
    private static void Main(string[] args)
    {
        var realSubject = new RealSubject();
        ClientCode(realSubject);

        Console.WriteLine();

        var proxy = new Proxy(realSubject);
        ClientCode(proxy);
    }

    private static void ClientCode(ISubject subject)
    {
        subject.Request();
    }
}