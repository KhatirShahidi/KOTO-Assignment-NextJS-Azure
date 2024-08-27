using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MyHttpFunction
{
    public class my_function_app
    {
        private readonly ILogger<my_function_app> _logger;

        public my_function_app(ILogger<my_function_app> logger)
        {
            _logger = logger;
        }

        [Function("my_function_app")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = new { message = "Welcome to Azure Functions!" };

            return new OkObjectResult(response);
        }
    }
}
