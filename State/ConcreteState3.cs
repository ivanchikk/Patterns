namespace State;

public class ConcreteState3 : State
{
    public override void Handle1(Context context)
    {
        Console.WriteLine("ConcreteState3: Handling1");
        context.State = new ConcreteState1();
    }

    public override void Handle2(Context context)
    {
        Console.WriteLine("ConcreteState3: Handling2");
        context.State = new ConcreteState2();
    }

    public override void Handle3(Context context)
    {
        Console.WriteLine("ConcreteState3: Handling2");
        context.State = new ConcreteState3();
    }
}