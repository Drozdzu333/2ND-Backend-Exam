namespace _2ND_Backend_Exam.API.Middleware
{
    public class ErrorHandlingMiddleware : IMiddleware
    {
        private readonly ILogger<ErrorHandlingMiddleware> _logger;

        public ErrorHandlingMiddleware(ILogger<ErrorHandlingMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            catch (ResourceNotFoundException e)
            {
                _logger.LogError(e, e.Message);
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync(e.Message);
            }
            catch(EmptyResourceListException e)
            {
                _logger.LogError(e, e.Message);
                context.Response.StatusCode = 204;
                await context.Response.WriteAsync(e.Message);
            }
            catch(ModificationRejectedException e)
            {
                _logger.LogError(e, e.Message);
                context.Response.StatusCode = 304;
                await context.Response.WriteAsync(e.Message);
            }
            catch (RecordAlreadyExistException e)
            {
                _logger.LogError(e, e.Message);
                context.Response.StatusCode = 409;
                await context.Response.WriteAsync(e.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("Something went wrong.");
            }
        }
    }
}