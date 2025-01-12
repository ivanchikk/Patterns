namespace FactoryMethod;

public abstract class Creator
{
    public abstract IProduct FactoryMethod();

    public string SomeOperation()
    {
        var product = FactoryMethod();

        var result = product.Operation();

        return result;
    }
}