using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastStorage _service;

    public WeatherForecastController(IWeatherForecastStorage service)
    {
        _service = service;
    }

    [HttpGet]
    public List<WeatherForecast> GetAll()
    {
        return _service.GetAll();
    }

    [HttpPost]
    public void Post(CreateWeatherDto newWeather)
    {
        _service.Post(newWeather);
    }

    [HttpPut]
    public WeatherForecast Put(Guid id, CreateWeatherDto newWeather)
    {
        return _service.Put(id, newWeather);
    }

    [HttpDelete]
    public void Delete(Guid id)
    {
        _service.Delete(id);
    }
}