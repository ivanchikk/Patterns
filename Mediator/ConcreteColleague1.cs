namespace Mediator;

public class ConcreteColleague1 : Colleague
{
    public void Operation1()
    {
        Console.WriteLine("ConcreteColleague1: Operation1");

        Mediator?.Notify("ConcreteColleague1 message", this);
    }

    public void Operation2()
    {
        Console.WriteLine("ConcreteColleague1: Operation2");
    }
}