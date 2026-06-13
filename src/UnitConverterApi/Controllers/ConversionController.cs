using Microsoft.AspNetCore.Mvc;
using UnitConverterApi.Models;
using UnitConverterApi.Services;

namespace UnitConverterApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConversionController : ControllerBase
{
    private readonly IUnitConversionService _service;

    public ConversionController(IUnitConversionService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Convert(ConversionRequest request)
    {
        try
        {
            return Ok(_service.Convert(request));
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}