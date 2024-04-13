using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Cloud5mins.ShortenerTools.Functions.Functions
{
    public class KeepAlive
    {
        private readonly ILogger<KeepAlive> _logger;

        public KeepAlive(ILogger<KeepAlive> logger)
        {
            _logger = logger;
        }

        [Function("KeepAlive")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "api/KeepAlive")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Keep Alive was executed successfully!");
        }
    }
}
