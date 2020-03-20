using System.Collections.Generic;
using System.Linq;
using Calculator.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Calculator.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiRequestLogsController : ControllerBase
    {
        private readonly ILogger<CalculatorController> logger;
        private readonly CalculatorContext calculatorContext;

        public ApiRequestLogsController(ILogger<CalculatorController> logger, CalculatorContext calculatorContext)
        {
            this.logger = logger;
            this.calculatorContext = calculatorContext;
        }

        [HttpGet]
        public IEnumerable<ApiRequestLog> GetAll()
        {
            return calculatorContext.ApiRequestLogs.ToList();
        }
    }
}
