namespace Mediator;

public class ConcreteColleague2 : Colleague
{
    public void Operation1()
    {
        Console.WriteLine("ConcreteColleague2: Operation1");

        Mediator?.Notify("ConcreteColleague2 message", this);
    }

    public void Operation2()
    {
        Console.WriteLine("ConcreteColleague2: Operation2");
    }
}