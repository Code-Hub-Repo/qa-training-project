using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpPost("add")]
    [ProducesResponseType(typeof(CalculationResult), StatusCodes.Status200OK)]
    public IActionResult Add([FromBody] CalculationRequest request)
    {
        var result = request.Number1 + request.Number2;
        return Ok(new CalculationResult
        {
            Number1 = request.Number1,
            Number2 = request.Number2,
            Operation = "+",
            Result = result
        });
    }

    [HttpPost("subtract")]
    [ProducesResponseType(typeof(CalculationResult), StatusCodes.Status200OK)]
    public IActionResult Subtract([FromBody] CalculationRequest request)
    {
        var result = request.Number1 - request.Number2;
        return Ok(new CalculationResult
        {
            Number1 = request.Number1,
            Number2 = request.Number2,
            Operation = "-",
            Result = result
        });
    }
}

public class CalculationRequest
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }
}

public class CalculationResult
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }
    public string Operation { get; set; } = string.Empty;
    public int Result { get; set; }
}
