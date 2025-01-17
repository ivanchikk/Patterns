namespace TemplateMethod;

public class ConcreteClass1 : AbstractClass
{
    protected override void Operation1()
    {
        Console.WriteLine("ConcreteClass1: Operation1");
    }

    protected override void Operation2()
    {
        Console.WriteLine("ConcreteClass1: Operation2");
    }

    protected override void Hook1()
    {
        Console.WriteLine("ConcreteClass1: Hook1");
    }
}