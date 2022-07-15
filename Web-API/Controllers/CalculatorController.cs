using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Addition")]
        public double Addition(double left, double right)
        {
            return Web_API_Lib.Calculator.Add(left, right);
        }

        [HttpGet("Subtraction")]
        public double Subtraction(double left, double right)
        {
            return Web_API_Lib.Calculator.Subtract(left, right);
        }

        [HttpGet("Multiplication")]
        public double Multiplication(double left, double right)
        {
            return Web_API_Lib.Calculator.Multiply(left, right);
        }

        [HttpGet("Division")]
        public double Division(double left, double right)
        {
            return Web_API_Lib.Calculator.Divide(left, right);
        }

    }
}
