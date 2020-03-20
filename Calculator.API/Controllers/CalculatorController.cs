using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public CalculatorController(ILogger<CalculatorController> logger, ICalculator calculator)
        {
            this.logger = logger;
            this.calculator = calculator;
        }

        [HttpPost]
        public float Calculate([FromBody] string expression)
        {
            return calculator.CalculateStringExpression(expression);
        }
    }
}
