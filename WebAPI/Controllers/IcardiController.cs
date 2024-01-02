using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IcardiController : Controller
{
    private readonly ILogOperation _logOperation;

    public IcardiController(ILogOperation logOperation)
    {
        _logOperation = logOperation;
    }

    [HttpGet]
    public IActionResult Run()
    {
        while (true)
        {
            int val = new Random().Next(1, 999999);

            if (val % 22 == 0)
                _logOperation.Error<IcardiController>($"value is {val}... this value is divided by exactly!!!");
            else 
                _logOperation.Information<IcardiController>($"value is {val} and this operation was completed successfully");
            
            Thread.Sleep(1250);
        }
    }
}