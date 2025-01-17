namespace FluentBuilder;

public class Product
{
    public int IntProperty { get; set; }
    public string StringProperty { get; set; } = string.Empty;
    public NestedProduct? NestedProduct { get; set; }

    public override string ToString()
    {
        return $"IntProperty: {IntProperty}, " +
               $"StringProperty: {StringProperty}, " +
               $"NestedProduct: {{{NestedProduct}}}";
    }
}