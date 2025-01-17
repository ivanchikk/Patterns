namespace Observer;

public class ConcreteObserver2 : IObserver
{
    public void Update(Subject subject)
    {
        if ((subject as ConcreteSubject1)?.State == "ConcreteSubject1")
            Console.WriteLine("ConcreteObserver2 reacted to ConcreteSubject1");

        else if ((subject as ConcreteSubject2)?.State == "ConcreteSubject2")
            Console.WriteLine("ConcreteObserver2 reacted to ConcreteSubject2");
    }
}