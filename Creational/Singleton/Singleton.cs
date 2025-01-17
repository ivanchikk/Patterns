namespace Singleton;

// Not quite as lazy, but thread-safe without using locks
public sealed class Singleton1
{
    // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
    static Singleton1()
    {
    }

    private Singleton1()
    {
    }

    public static Singleton1 Instance { get; } = new();
}

// Fully lazy and thread-safe
public sealed class Singleton2
{
    private Singleton2()
    {
    }

    public static Singleton2 Instance => Nested.instance;

    private class Nested
    {
        // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
        static Nested()
        {
        }

        internal static readonly Singleton2 instance = new();
    }
}

// Fully lazy and thread-safe
public sealed class Singleton3
{
    private Singleton3()
    {
    }

    private static readonly Lazy<Singleton3> Lazy = new(() => new Singleton3());

    public static Singleton3 Instance => Lazy.Value;
}