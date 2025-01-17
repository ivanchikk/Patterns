namespace ChainOfResponsibility;

public class ConcreteHandler1 : AbstractHandler
{
    public override object? Handle(object request)
    {
        return (request as string) == "ConcreteHandler1"
            ? "ConcreteHandler1: Handling request"
            : base.Handle(request);
    }
}