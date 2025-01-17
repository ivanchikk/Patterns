namespace Strategy;

public class ConcreteStrategy2 : IStrategy
{
    public string Execute(string input)
    {
        return $"ConcreteStrategy2: Executing with '{input}'";
    }
}