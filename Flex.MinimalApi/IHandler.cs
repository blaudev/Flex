namespace Flex.MinimalApi;

public interface IHandler<TResponse>
    where TResponse : class
{
    Task<TResponse> HandleAsync();
}

public interface IHandler<TRequest, TResponse> : IHandler<TResponse>
    where TResponse : class
    where TRequest : class
{
    Task<TResponse> HandleAsync(TRequest request);
}
