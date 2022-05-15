using FluentValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LeadsController : ControllerBase 
{
    [HttpPost("")]
    public IActionResult Create(Lead model)
    {
        return Ok();
    }
    
}