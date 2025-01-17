namespace Interpreter;

public class TerminalExpression2 : AbstractExpression
{
    public override string Interpret(Context context)
    {
        return $"{{TermExpr2: {context.GetData()}}}";
    }
}