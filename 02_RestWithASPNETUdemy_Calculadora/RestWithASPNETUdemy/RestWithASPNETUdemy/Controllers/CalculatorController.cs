using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
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


        //calcula a soma de dois números passados na url 
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult GetSoma(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber)  + ConvertToDecimal(secondNumber) ;
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        //calcula a subtração de dois números passados na url
        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult GetSubtracao(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid Input");
        }

        //calcula o produto de dois números passados na url
        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public IActionResult GetMultiplicacao(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var mult = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(mult.ToString());
             
            }
            return BadRequest("Invalid Input");
        }

        //calcula a divisão de dois numeros passados na url
        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult GetDivisao(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var div = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(div.ToString());
            }
            return BadRequest("Invalid Input");
        }

        //calcula a media dos dois numeros passados na url
        [HttpGet("media/{firstNumber}/{secondNumber}")]
        public IActionResult GetMedia(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var med = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok(med.ToString());
            }
            return BadRequest("Invalid Input");
        }

        //calcula a potencia de um número, sendo que o segundo número é o expoente
        [HttpGet("pot/{firstNumber}/{secondNumber}")]
        public IActionResult GetPot(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var pot = Math.Pow((double)ConvertToDecimal(firstNumber), (double)ConvertToDecimal(secondNumber));
                return Ok(pot.ToString());
            }
            return BadRequest("Invalid Input");
        }

        //calcula a raiz quadrada do numero passado na url
        [HttpGet("raiz/{firstNumber}")]
        public IActionResult GetRaiz(string firstNumber)
        {
            if(IsNumeric(firstNumber))
            {
                var raiz = Math.Sqrt((double)ConvertToDecimal(firstNumber));
                return Ok(raiz.ToString());
            }

            return BadRequest("Invalid Input");
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, 
                    System.Globalization.NumberStyles.Any, 
                    System.Globalization.NumberFormatInfo.InvariantInfo,
                    out number);
            return isNumber;

            
        }
    }
}
