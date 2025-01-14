namespace Visitor;

public class ConcreteComponent1 : IComponent
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponent1(this);
    }

    public string Operation()
    {
        return "ConcreteComponent1_Operation";
    }
}