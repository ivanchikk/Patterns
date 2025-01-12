namespace Builder;

public class Product
{
    private readonly List<object> _parts = [];

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public string ListParts()
    {
        var result = _parts.Aggregate(string.Empty, (current, part) => current + part + Environment.NewLine);

        return result.TrimEnd();
    }
}