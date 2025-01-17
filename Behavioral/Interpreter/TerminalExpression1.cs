namespace Interpreter;

public class TerminalExpression1 : AbstractExpression
{
    public override string Interpret(Context context)
    {
        return $"{{TermExpr1: {context.GetData()}}}";
    }
}