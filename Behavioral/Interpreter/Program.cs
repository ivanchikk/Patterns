namespace Interpreter;

class Program
{
    private static void Main(string[] args)
    {
        var context = new Context();
        context.AddData("data1", "data2", "data3", "data4", "data5");

        AbstractExpression exp =
            new NonterminalExpression1(
                new NonterminalExpression1(
                    new TerminalExpression1(),
                    new TerminalExpression2()
                ),
                new NonterminalExpression2(
                    new NonterminalExpression1(new TerminalExpression2(), new TerminalExpression2()),
                    new TerminalExpression1()
                )
            );

        Console.WriteLine(exp.Interpret(context));
    }
}