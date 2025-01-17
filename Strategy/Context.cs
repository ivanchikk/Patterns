namespace Strategy;

public class Context(IStrategy strategy)
{
    public IStrategy Strategy { get; set; } = strategy;
    public string Input { get; set; } = string.Empty;

    public string Operation()
    {
        return Strategy.Execute(Input);
    }
}