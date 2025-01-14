using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Shared;
using MassTransit;
using MediatR;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;

[ExcludeFromTopology]
public interface ICommand : IRequest<Result>
{
}

[ExcludeFromTopology]
public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}