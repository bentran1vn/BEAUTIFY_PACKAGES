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

    public static RouteHandlerBuilder MapPostCommandFromForm<TCommand>(
        this IEndpointRouteBuilder builder,
        string pattern)
    {
        return builder.MapPost(pattern, (ISender sender, [FromForm] TCommand command)
            => HandleCommand(sender, command));
    }

    public static RouteHandlerBuilder MapPutCommand<TCommand>(
        this IEndpointRouteBuilder builder,
        string pattern)
    {
        return builder.MapPut(pattern, (ISender sender, [FromBody] TCommand command)
            => HandleCommand(sender, command));
    }

    public static RouteHandlerBuilder MapPutCommandFromFrom<TCommand>(
        this IEndpointRouteBuilder builder,
        string pattern)
    {
        return builder.MapPut(pattern, (ISender sender, [FromForm] TCommand command)
            => HandleCommand(sender, command));
    }

    public static RouteHandlerBuilder MapDeleteCommand<TCommand>(
        this IEndpointRouteBuilder builder,
        string pattern)
    {
        return builder.MapDelete(pattern, (ISender sender, [FromBody] TCommand command)
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