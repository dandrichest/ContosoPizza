using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class SalesController : ControllerBase
{
    [HttpGet("summary")]
    public ActionResult<string> GetSalesSummary()
    {
        // Assuming sales files are in a "Sales" directory in the project root
        var salesDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Sales");
        var summary = SalesService.GenerateSalesSummary(salesDirectory);
        return Ok(summary);
    }
}