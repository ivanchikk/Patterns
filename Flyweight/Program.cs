namespace Flyweight;

class Program
{
    private static void Main(string[] args)
    {
        var factory = new FlyweightFactory();

        foreach (var (productFlyweight, productContext) in _productFlyweights.Zip(_productContexts))
        {
            var flyweight = factory.GetFlyweight(productFlyweight);
            flyweight.Operation(productContext);
            Console.WriteLine();
        }
    }

    private static List<Product> _productFlyweights =
    [
        new Product { RepeatingState1 = "A", RepeatingState2 = "B" },
        new Product { RepeatingState1 = "A", RepeatingState2 = "C" },
        new Product { RepeatingState1 = "B", RepeatingState2 = "C" },
        new Product { RepeatingState1 = "A", RepeatingState2 = "B" },
        new Product { RepeatingState1 = "A", RepeatingState2 = "C" }
    ];

    private static List<Product> _productContexts =
    [
        new Product { UniqueState1 = "1", UniqueState2 = "2", UniqueState3 = "3" },
        new Product { UniqueState1 = "4", UniqueState2 = "5", UniqueState3 = "6" },
        new Product { UniqueState1 = "7", UniqueState2 = "8", UniqueState3 = "9" },
        new Product { UniqueState1 = "10", UniqueState2 = "11", UniqueState3 = "12" },
        new Product { UniqueState1 = "13", UniqueState2 = "14", UniqueState3 = "15" }
    ];
}