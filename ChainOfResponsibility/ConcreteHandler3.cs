namespace ChainOfResponsibility;

public class ConcreteHandler3 : AbstractHandler
{
    public override object? Handle(object request)
    {
        return (request as string) == "ConcreteHandler3"
            ? "ConcreteHandler3: Handling request"
            : base.Handle(request);
    }
}