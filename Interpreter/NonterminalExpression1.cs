namespace Interpreter;

public class NonterminalExpression1(AbstractExpression leftExpression, AbstractExpression rightExpression)
    : AbstractExpression
{
    public override string Interpret(Context context)
    {
        return $"({leftExpression.Interpret(context)} <operation1> {rightExpression.Interpret(context)})";
    }
}