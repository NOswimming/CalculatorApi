using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Repository;
using Calculator.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Calculator.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> logger;
        private readonly ICalculator calculator;
        private readonly CalculatorContext calculatorContext;

        public CalculatorController(ILogger<CalculatorController> logger, ICalculator calculator, CalculatorContext calculatorContext)
        {
            this.logger = logger;
            this.calculator = calculator;
            this.calculatorContext = calculatorContext;
        }

        [HttpPost]
        public float Calculate([FromBody] string expression)
        {
            LogRequest();
            return calculator.CalculateStringExpression(expression);
        }

        private void LogRequest()
        {            
            var log = new ApiRequestLog
            {
                ApiRequestEndpoint = HttpContext.Request.Path,
                IPAddress = HttpContext.Connection.RemoteIpAddress.ToString(),
                Created = DateTimeOffset.Now
            };
            calculatorContext.ApiRequestLogs.Add(log);
            calculatorContext.SaveChanges();
        }
    }
}
