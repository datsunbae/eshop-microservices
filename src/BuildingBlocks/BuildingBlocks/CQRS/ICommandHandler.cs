using MediatR;

namespace BuildingBlocks.CQRS;

public interface ICommandHandler<in TRequest>
    : ICommandHandler<TRequest, Unit>
    where TRequest : ICommand<Unit>
{
}

public interface ICommandHandler<in TRequest, TResponse>
    : IRequestHandler<TRequest, TResponse>
    where TRequest : ICommand<TResponse>
    where TResponse : notnull
{
}
