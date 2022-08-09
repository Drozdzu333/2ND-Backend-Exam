namespace _2ND_Backend_Exam.API.Middleware
{
    public class LoggingMiddleware : IMiddleware
    {
        private readonly ILogger _logger;

        public LoggingMiddleware(ILogger<LoggingMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            _logger.LogInformation($"{DateTime.UtcNow} UTC - Request: {context.Request.Method} - {context.Request.Scheme}://{context.Request.Host}{context.Request.Path}");

            await next.Invoke(context);

            switch (context.Response.StatusCode)
            {
                case int n when (n >= 100 && n < 200):
                    _logger.LogTrace($"{DateTime.UtcNow} UTC - Response status code: {context.Response.StatusCode}");
                    break;

                case int n when (n >= 200 && n < 300):
                    _logger.LogInformation($"{DateTime.UtcNow} UTC - Response status code: {context.Response.StatusCode}");
                    break;

                case int n when (n >= 300 && n < 400):
                    _logger.LogDebug($"{DateTime.UtcNow} UTC - Request: {context.Request.Method} - " +
                        $"{context.Request.Scheme}://{context.Request.Host}{context.Request.Path}" +
                        $"\n Status code: {context.Response.StatusCode}");
                    break;

                case int n when (n >= 400 && n < 500):
                    _logger.LogWarning($"{DateTime.UtcNow} UTC - Request: {context.Request.Method} - " +
                        $"{context.Request.Scheme}://{context.Request.Host}{context.Request.Path}" +
                        $"\n Status code: {context.Response.StatusCode}");
                    break;

                case int n when (n >= 500 && n < 600):
                    _logger.LogCritical($"{DateTime.UtcNow} UTC - Request: {context.Request.Method} - " +
                        $"{context.Request.Scheme}://{context.Request.Host}{context.Request.Path}" +
                        $"\n Status code: {context.Response.StatusCode}");
                    break;

                default:
                    _logger.LogInformation($"{DateTime.UtcNow} UTC - Response status code: {context.Response.StatusCode}");
                    break;
            }
        }
    }
}