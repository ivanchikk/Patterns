namespace Builder;

public class ConcreteBuilder1 : IBuilder
{
    private Product _product = new();

    public void AddA()
    {
        _product.Add("PART A: 1");
    }

    public void AddB()
    {
        _product.Add("PART B: 1");
    }

    public void AddC()
    {
        _product.Add("PART C: 1");
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