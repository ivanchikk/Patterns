namespace Interpreter;

public class NonterminalExpression2(AbstractExpression leftExpression, AbstractExpression rightExpression)
    : AbstractExpression
{
    public override string Interpret(Context context)
    {
        return $"({leftExpression.Interpret(context)} <operation2> {rightExpression.Interpret(context)})";
    }
}