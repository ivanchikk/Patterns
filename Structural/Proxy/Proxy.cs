namespace Proxy;

public class Proxy(RealSubject realSubject) : ISubject
{
    public void Request()
    {
        if (CheckAccess())
        {
            realSubject.Request();

            LogAccess();
        }
    }

    private static bool CheckAccess()
    {
        Console.WriteLine("Proxy: Checking access");

        return true;
    }

    private static void LogAccess()
    {
        Console.WriteLine("Proxy: Logging access");
    }
}