namespace FluentBuilder;

public class NestedProduct
{
    public int NestedIntProperty { get; set; }
    public string NestedStringProperty { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"NestedIntProperty: {NestedIntProperty}, " +
               $"NestedStringProperty: {NestedStringProperty}";
    }
}