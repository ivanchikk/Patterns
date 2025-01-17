namespace Strategy;

public class ConcreteStrategy1 : IStrategy
{
    public string Execute(string input)
    {
        return $"ConcreteStrategy1: Executing with '{input}'";
    }
}