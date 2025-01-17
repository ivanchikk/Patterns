namespace Visitor;

public interface IVisitor
{
    void VisitConcreteComponent1(ConcreteComponent1 component);
    void VisitConcreteComponent2(ConcreteComponent2 component);
}