using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Shared;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.PRESENTATION.Abstractions.Extention;
public static class EndpointRouteBuilderExtensions
{
    public static RouteHandlerBuilder MapPostCommand<TCommand>(
        this IEndpointRouteBuilder builder,
        string pattern)
    {
        return builder.MapPost(pattern, (ISender sender, [FromBody] TCommand command)
            => HandleCommand(sender, command));
    }

    private static async Task<IResult> HandleCommand<TCommand>(
        ISender sender,
        TCommand command)
    {
        var result = (Result)await sender.Send(command);
        return result.IsFailure ? ApiEndpoint.HandlerFailure(result) : Results.Ok(result);
    }
}