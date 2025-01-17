namespace Iterator;

class Program
{
    private static void Main(string[] args)
    {
        var a1 = new ConcreteAggregate1<string>();
        a1.Add("1");
        a1.Add("2");
        a1.Add("3");

        var i1 = a1.Iterator;
        while (i1.MoveNext())
            Console.WriteLine(i1.Current);

        Console.WriteLine();

        var a2 = new ConcreteAggregate2();
        a2.Add(1);
        a2.Add(2);
        a2.Add(3);

        a2.Iterator = new ConcreteIterator2<int>(a2);
        var i2 = a2.Iterator;
        while (i2.MoveNext())
            Console.WriteLine(i2.Current);
    }
}