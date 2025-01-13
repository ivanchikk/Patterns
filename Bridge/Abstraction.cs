namespace Bridge;

public class Abstraction(IImplementation implementation)
{
    protected IImplementation _implementation = implementation;

    public IImplementation Implementation
    {
        set => _implementation = value;
    }

    public virtual string Operation()
    {
        return "Abstract: Base operation with:\n" +
               _implementation.OperationImplementation();
    }
}