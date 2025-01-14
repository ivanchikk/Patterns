namespace Mediator;

public interface IMediator
{
    void Notify(string message, Colleague sender);
}