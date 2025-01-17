namespace Interpreter;

public class Context
{
    private readonly Queue<string> _data = [];

    public void AddData(params string[] data)
    {
        foreach (var x in data)
            _data.Enqueue(x);
    }

    public string GetData()
    {
        _data.TryDequeue(out var data);

        return data ?? "empty";
    }
}