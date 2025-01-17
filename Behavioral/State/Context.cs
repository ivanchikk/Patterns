namespace State;

public class Context(State state)
{
    private State _state = state;

    public State State
    {
        get => _state;
        set
        {
            Console.WriteLine($"Context: Switching to state '{value.GetType().Name}'");
            _state = value;
        }
    }

    public void Request1()
    {
        State.Handle1(this);
    }

    public void Request2()
    {
        State.Handle2(this);
    }

    public void Request3()
    {
        State.Handle3(this);
    }
}