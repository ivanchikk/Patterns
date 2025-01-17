namespace Adapter;

public class Adapter(Adaptee adaptee) : ITarget
{
    public string GetRequest()
    {
        return adaptee.GetSpecificRequest();
    }
}