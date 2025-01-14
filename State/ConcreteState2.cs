namespace State;

public class ConcreteState2 : State
{
    public override void Handle1(Context context)
    {
        Console.WriteLine("ConcreteState2: Handling1");
        context.State = new ConcreteState1();
    }

    public override void Handle2(Context context)
    {
        Console.WriteLine("ConcreteState2: Handling2");
        context.State = new ConcreteState2();
    }

    public override void Handle3(Context context)
    {
        Console.WriteLine("ConcreteState2: Handling2");
        context.State = new ConcreteState3();
    }
}