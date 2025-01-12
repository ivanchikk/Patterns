namespace Builder;

public class ConcreteBuilder2 : IBuilder
{
    private Product _product = new();

    public void AddA()
    {
        _product.Add("PART A: 2");
    }

    public void AddB()
    {
        // No part b
    }

    public void AddC()
    {
        _product.Add("PART C: 2");
    }

    public Product Build()
    {
        var result = _product;

        Reset();

        return result;
    }

    public void Reset()
    {
        _product = new Product();
    }
}