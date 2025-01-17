namespace Bridge;

public class ExtendedAbstraction1(IImplementation implementation) : Abstraction(implementation)
{
    public override string Operation()
    {
        return "ExtendedAbstraction1: Extended operation with:\n" +
               base.Operation();
    }
}