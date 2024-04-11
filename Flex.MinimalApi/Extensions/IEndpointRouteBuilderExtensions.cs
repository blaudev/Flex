using Flex.MinimalApi;

using Microsoft.AspNetCore.Routing;

namespace Microsoft.AspNetCore.Builder;

public static class IEndpointRouteBuilderExtensions
{
    public static RouteHandlerBuilder MapGet<TResponse>(this IEndpointRouteBuilder builder, string pattern)
        where TResponse : class
    {
        return builder.MapGet(pattern, async (IHandler<TResponse> handler) => await handler.HandleAsync());
    }

    public static RouteHandlerBuilder MapGet<TRequest, TResponse>(this IEndpointRouteBuilder builder, string pattern)
        where TRequest : class
        where TResponse : class
    {
        return builder.MapGet(pattern, async (IHandler<TRequest, TResponse> handler) => await handler.HandleAsync());
    }
}
