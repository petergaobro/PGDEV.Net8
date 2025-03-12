using Microsoft.AspNetCore.Mvc;
using PGDEV.Net8.Model;
using PGDEV.Net8.Service;
using System.Threading.Tasks;

namespace PGDEV.Net8.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    //setup allows you to log messages (e.g., errors, warnings,
    //and information) inside the controller using _logger
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    //public async Task<IEnumerable<WeatherForecast>> Get()
    public async Task<List<UserVo>> Get()
    {
        var userService = new UserService();
        var userList = await userService.Query();
        return userList;

        //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //{
        //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //    TemperatureC = Random.Shared.Next(-20, 55),
        //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //})
        //.ToArray();
    }
}
