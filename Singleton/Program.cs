namespace Singleton;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Starting Main\n");

        var s11 = Singleton1.Instance;
        var s12 = Singleton1.Instance;
        Console.WriteLine($"s11 = s12: {s11 == s12}");

        var s21 = Singleton2.Instance;
        var s22 = Singleton2.Instance;
        Console.WriteLine($"s21 = s22: {s21 == s22}");

        var s31 = Singleton3.Instance;
        var s32 = Singleton3.Instance;
        Console.WriteLine($"s31 = s32: {s31 == s32}");
    }
}