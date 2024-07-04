using System.Runtime.InteropServices;

namespace authentication_in_dotnet_core
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private const string APIKEY = "ApiKey";

        public ApiKeyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue(APIKEY, out var extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("API Key was not provided.");
                return;
            }

            // Validate the API Key
            if (!IsValidApiKey(extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorize client.");
                return;
            }

            await _next(context);
        }

        private bool IsValidApiKey(string extractedApiKey)
        {
            // Validate the API key (this is just an example)
            return extractedApiKey == "yourSecretApiKey";
        }
    }
}
