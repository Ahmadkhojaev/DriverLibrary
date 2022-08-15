
using DriverLibrary.Mapper;
using DriverLibrary.Model;
using DriverLibrary.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DriverLibrary.Controller;

[ApiController]
[Route("/api/controller")]

public class DriverController : ControllerBase
{
    private readonly ILogger<DriverController> _logger;
    private readonly IDriverService _service;

    public DriverController(ILogger<DriverController> logger , IDriverService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpPost("/addDriver")]
    public async Task<IActionResult> AddDriver([FromForm] DriverModel model)
    {
        if (ModelState.IsValid)
        {
            await _service.InsertDriverAsync(model.ToEntity());
            return Ok(model);
        }
        return BadRequest();
    }

    [HttpGet("/getall")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _service.GetAllDriverAsync();
        return Ok(result);
    } 
}