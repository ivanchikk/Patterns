namespace TemplateMethod;

public class ConcreteClass2 : AbstractClass
{
    protected override void Operation1()
    {
        Console.WriteLine("ConcreteClass2: Operation1");
    }

    protected override void Operation2()
    {
        Console.WriteLine("ConcreteClass2: Operation2");
    }

    protected override void Hook2()
    {
        Console.WriteLine("ConcreteClass2: Hook2");
    }
}