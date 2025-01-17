namespace Visitor;

public class ConcreteComponent2 : IComponent
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponent2(this);
    }

    public string Operation()
    {
        return "ConcreteComponent2_Operation";
    }
}