namespace ChainOfResponsibility;

public class ConcreteHandler2 : AbstractHandler
{
    public override object? Handle(object request)
    {
        return (request as string) == "ConcreteHandler2"
            ? "ConcreteHandler2: Handling request"
            : base.Handle(request);
    }
}