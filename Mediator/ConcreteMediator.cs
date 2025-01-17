namespace Mediator;

public class ConcreteMediator : IMediator
{
    public ConcreteMediator(ConcreteColleague1 colleague1, ConcreteColleague2 colleague2)
    {
        Colleague1 = colleague1;
        Colleague1.Mediator = this;
        Colleague2 = colleague2;
        Colleague2.Mediator = this;
    }

    public ConcreteColleague1 Colleague1 { private get; set; }
    public ConcreteColleague2 Colleague2 { private get; set; }

    public void Notify(string message, Colleague sender)
    {
        if (sender == Colleague1)
        {
            Console.WriteLine($"Mediator gets '{message}' and reacts on it");
            Colleague2.Operation2();
        }

        else if (sender == Colleague2)
        {
            Console.WriteLine($"Mediator gets '{message}' and reacts on it");
            Colleague1.Operation2();
        }
    }
}