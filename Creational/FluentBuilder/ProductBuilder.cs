namespace FluentBuilder;

public class ProductBuilder
{
    private Product _product = new();
    private readonly NestedProductBuilder _nestedProductBuilder = NestedProductBuilder.Create();

    private ProductBuilder()
    {
    }

    public static ProductBuilder Create() => new();

    public ProductBuilder WithIntProperty(int value)
    {
        _product.IntProperty = value;

        return this;
    }

    public ProductBuilder WithStringProperty(string value)
    {
        _product.StringProperty = value;

        return this;
    }

    public ProductBuilder WithNestedProduct(Action<NestedProductBuilder> action)
    {
        action(_nestedProductBuilder);

        _product.NestedProduct = _nestedProductBuilder.Build();

        return this;
    }

    public Product Build()
    {
        var result = _product;

        _product = new Product();

        return result;
    }
}