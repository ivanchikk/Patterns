namespace Bridge;

public class ExtendedAbstraction2(IImplementation implementation) : Abstraction(implementation)
{
    public override string Operation()
    {
        return "ExtendedAbstraction2: Extended operation with:\n" +
               base.Operation();
    }
}