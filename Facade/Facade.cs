namespace Facade;

public class Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
{
    protected Subsystem1 Subsystem1 = subsystem1;
    protected Subsystem2 Subsystem2 = subsystem2;

    public string Operation1()
    {
        var result = "Facade operation1:\n";

        result += Subsystem1.Operation1();
        result += Environment.NewLine;
        result += Subsystem2.Operation1();

        return result;
    }

    public string Operation2()
    {
        var result = "Facade operation2:\n";

        result += Subsystem1.Operation2();
        result += Environment.NewLine;
        result += Subsystem2.Operation2();

        return result;
    }
}