using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("sum/{firstNumber}/{secondNumber}")]
    public IActionResult Sum(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
            return Ok(sum.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("sub/{firstNumber}/{secondNumber}")]
    public IActionResult Sub(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
            return Ok(sub.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("divider/{firstNumber}/{secondNumber}")]
    public IActionResult Divider(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var divider = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
            return Ok(divider.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("mult/{firstNumber}/{secondNumber}")]
    public IActionResult Mult(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var mult = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
            return Ok(mult.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("mean/{firstNumber}/{secondNumber}")]
    public IActionResult Mean(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var mean = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
            return Ok(mean.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("square/{firstNumber}")]
    public IActionResult Square(string firstNumber)
    {
        if (IsNumeric(firstNumber))
        {
            var square = Math.Sqrt((double)ConvertToDecimal(firstNumber));
            return Ok(square.ToString());
        }
        return BadRequest("Invalid Input");
    }

    private bool IsNumeric(string strNumber)
    {
        double number;
        bool isNumber = double.TryParse(
            strNumber,
            System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo,
            out number);
        return isNumber;
    }
    private decimal ConvertToDecimal(string strNumber)
    {
        decimal decimalValue;
        if (decimal.TryParse(strNumber, out decimalValue))
        {
            return decimalValue;
        }
        return 0;
    }


}
