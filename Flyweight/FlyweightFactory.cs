namespace Flyweight;

public class FlyweightFactory
{
    private readonly Dictionary<string, Flyweight> _flyweights = new();

    public Flyweight GetFlyweight(Product product)
    {
        var key = GetKey(product);

        if (_flyweights.TryGetValue(key, out var flyweight))
        {
            Console.WriteLine($"Taking existing flyweight with key: {key}");
            return flyweight;
        }

        _flyweights.Add(key, new Flyweight(product));
        Console.WriteLine($"Creating new flyweight with key: {key}");

        return _flyweights[key];
    }

    private static string GetKey(Product product)
    {
        return $"{product.RepeatingState1}_{product.RepeatingState2}";
    }
}