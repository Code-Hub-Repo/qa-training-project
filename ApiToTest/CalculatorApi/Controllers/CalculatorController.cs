using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

using CalculatorApi.Services;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpPost("add")]
        [ProducesResponseType(typeof(CalculationResult), StatusCodes.Status200OK)]
        public IActionResult Add([FromBody] CalculationRequest request)
        {
            if (!ModelState.IsValid || request.Number1 == null || request.Number2 == null)
            {
                return BadRequest(ModelState);
            }
            var result = _calculatorService.Add(request.Number1.Value, request.Number2.Value);
            return Ok(new CalculationResult
            {
                Number1 = request.Number1.Value,
                Number2 = request.Number2.Value,
                Operation = "+",
                Result = result
            });
        }

        [HttpPost("subtract")]
        [ProducesResponseType(typeof(CalculationResult), StatusCodes.Status200OK)]
        public IActionResult Subtract([FromBody] CalculationRequest request)
        {
            if (!ModelState.IsValid || request.Number1 == null || request.Number2 == null)
            {
                return BadRequest(ModelState);
            }
            var result = _calculatorService.Subtract(request.Number1.Value, request.Number2.Value);
            return Ok(new CalculationResult
            {
                Number1 = request.Number1.Value,
                Number2 = request.Number2.Value,
                Operation = "-",
                Result = result
            });
        }
    }

    public class CalculationRequest
    {
        [Required(ErrorMessage = "Number1 is required.")]
        public int? Number1 { get; set; }
        [Required(ErrorMessage = "Number2 is required.")]
        public int? Number2 { get; set; }
    }

    public class CalculationResult
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string Operation { get; set; } = string.Empty;
        public int Result { get; set; }
    }
}
