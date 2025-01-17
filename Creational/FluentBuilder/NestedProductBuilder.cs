namespace FluentBuilder;

public class NestedProductBuilder
{
    private NestedProduct _nestedProduct = new();

    private NestedProductBuilder()
    {
    }

    public static NestedProductBuilder Create() => new();

    public NestedProductBuilder WithNestedIntProperty(int value)
    {
        _nestedProduct.NestedIntProperty = value;

        return this;
    }

    public NestedProductBuilder WithNestedStringProperty(string value)
    {
        _nestedProduct.NestedStringProperty = value;

        return this;
    }

    public NestedProduct Build()
    {
        var result = _nestedProduct;

        _nestedProduct = new NestedProduct();

        return result;
    }
}