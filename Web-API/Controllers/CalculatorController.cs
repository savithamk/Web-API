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


        //GET http method to add two numbers
        [HttpGet("Addition")]
        public double Addition(double left, double right)
        {
            return Web_API_Lib.Calculator.Add(left, right);
        }

        //GET http method to subtract two numbers
        [HttpGet("Subtraction")]
        public double Subtraction(double left, double right)
        {
            return Web_API_Lib.Calculator.Subtract(left, right);
        }

        //GET http method to multiply two numbers
        [HttpGet("Multiplication")]
        public double Multiplication(double left, double right)
        {
            return Web_API_Lib.Calculator.Multiply(left, right);
        }

        //GET http method to divide two numbers
        [HttpGet("Division")]
        public IActionResult Division(double left, double right)
        {
            try
            {
                return Ok(Web_API_Lib.Calculator.Divide(left, right));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception occured while dividing number by zero", e);
                return BadRequest();

            }

        }

    }
}
