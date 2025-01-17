namespace Observer;

class Program
{
    private static void Main(string[] args)
    {
        var s1 = new ConcreteSubject1();
        var s2 = new ConcreteSubject2();

        var o1 = new ConcreteObserver1();
        var o2 = new ConcreteObserver2();

        s1.Attach(o1);
        s1.Attach(o2);

        s1.State = "ConcreteSubject1";
        s1.Notify();

        Console.WriteLine();

        s2.Attach(o1);
        s2.Attach(o2);

        s2.State = "ConcreteSubject2";
        s2.Notify();

        Console.WriteLine();

        s1.Detach(o1);
        s1.Notify();

        Console.WriteLine();

        s2.Detach(o2);
        s2.Notify();
    }
}