namespace Flyweight;

public class Flyweight(Product product)
{
    private Product _intrinsicState = product;

    public void Operation(Product extrinsicState)
    {
        Console.WriteLine(
            $"Intrinsic state: " +
            $"{_intrinsicState.RepeatingState1} " +
            $"{_intrinsicState.RepeatingState2}");
        Console.WriteLine(
            $"Extrinsic state: " +
            $"{extrinsicState.UniqueState1} " +
            $"{extrinsicState.UniqueState2} " +
            $"{extrinsicState.UniqueState3}");
    }
}