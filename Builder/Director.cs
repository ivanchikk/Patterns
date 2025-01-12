namespace Builder;

public class Director(IBuilder builder)
{
    public IBuilder Builder { private get; set; } = builder;

    public void BuildMinimal()
    {
        Builder.AddA();
    }

    public void BuildFull()
    {
        Builder.AddA();
        Builder.AddB();
        Builder.AddC();
    }
}