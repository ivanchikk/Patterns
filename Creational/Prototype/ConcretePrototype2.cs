namespace Prototype;

public class ConcretePrototype2(int publicInt) : IPrototype
{
    private int _privateInt = 12;

    public int PublicInt { get; set; } = publicInt;
    public int PublicIntProperty1 { get; set; }
    public int PublicIntProperty2 { get; set; }
    public int PublicIntProperty3 { get; set; }

    public IPrototype Clone()
    {
        var result = new ConcretePrototype2(PublicInt)
        {
            _privateInt = _privateInt,
            PublicIntProperty1 = PublicIntProperty1,
            PublicIntProperty2 = PublicIntProperty2,
            PublicIntProperty3 = PublicIntProperty3
        };

        return result;
    }

    public override string ToString()
    {
        return $"PrivateInt: {_privateInt}, " +
               $"PublicInt: {PublicInt}, " +
               $"PublicIntProperty1: {PublicIntProperty1}, " +
               $"PublicIntProperty2: {PublicIntProperty2}, " +
               $"PublicIntProperty3: {PublicIntProperty3}";
    }
}