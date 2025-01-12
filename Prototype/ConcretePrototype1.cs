namespace Prototype;

public class ConcretePrototype1(string publicString) : IPrototype
{
    private string _privateString = "private";

    public string PublicString { get; set; } = publicString;
    public string? PublicStringProperty1 { get; set; }
    public string? PublicStringProperty2 { get; set; }
    public string? PublicStringProperty3 { get; set; }

    public IPrototype Clone()
    {
        var result = new ConcretePrototype1(PublicString)
        {
            _privateString = _privateString,
            PublicStringProperty1 = PublicStringProperty1,
            PublicStringProperty2 = PublicStringProperty2,
            PublicStringProperty3 = PublicStringProperty3
        };

        return result;
    }

    public override string ToString()
    {
        return $"PrivateString: {_privateString}, " +
               $"PublicString: {PublicString}, " +
               $"PublicStringProperty1: {PublicStringProperty1}, " +
               $"PublicStringProperty2: {PublicStringProperty2}, " +
               $"PublicStringProperty3: {PublicStringProperty3}";
    }
}