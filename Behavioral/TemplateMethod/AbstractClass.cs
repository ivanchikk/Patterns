namespace TemplateMethod;

public abstract class AbstractClass
{
    public void TemplateMethod()
    {
        BaseOperation1();
        Operation1();
        BaseOperation2();
        Hook1();
        Operation2();
        Hook2();
    }

    protected void BaseOperation1()
    {
        Console.WriteLine("BaseOperation1");
    }

    protected void BaseOperation2()
    {
        Console.WriteLine("BaseOperation2");
    }

    protected abstract void Operation1();
    protected abstract void Operation2();

    protected virtual void Hook1()
    {
        Console.WriteLine("Hook1: Not implemented");
    }

    protected virtual void Hook2()
    {
        Console.WriteLine("Hook2: Not implemented");
    }
}