namespace FluentBuilder;

class Program
{
    private static void Main(string[] args)
    {
        var product1 = ProductBuilder.Create()
            .WithIntProperty(1)
            .WithStringProperty("1")
            .WithNestedProduct(b => b
                .WithNestedIntProperty(2)
                .WithNestedStringProperty("2"))
            .Build();

        Console.WriteLine(product1);

        var product2 = ProductBuilder.Create()
            .Build();

        Console.WriteLine(product2);
    }
}