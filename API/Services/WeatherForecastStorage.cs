namespace API.Services;

public class WeatherForecastStorage : IWeatherForecastStorage
{
    private List<WeatherForecast> _weathers;

    public WeatherForecastStorage()
    {
        _weathers = new();
    }
    public List<WeatherForecast> GetAll()
    {
        return _weathers;
    }

    public void Post(CreateWeatherDto newWeather)
    {
        var date = new DateOnly(newWeather.Year, newWeather.Month, newWeather.Day);
        var weather = new WeatherForecast()
        {
            Date = date,
            TemperatureC = newWeather.TemperatureC
        };
        _weathers.Add(weather);
    }

    public WeatherForecast Put(Guid id , CreateWeatherDto updatedWeather)
    {
        var firstOrDefault 
            = _weathers.FirstOrDefault(w => w.Id == id);
        var date = new DateOnly(updatedWeather.Year, updatedWeather.Month, updatedWeather.Day);
        var weather = new WeatherForecast()
        {
            Id = firstOrDefault.Id,
            Date = date,
            TemperatureC = updatedWeather.TemperatureC,
            Summary = updatedWeather.Summary
        };
        _weathers.Remove(firstOrDefault);
        _weathers.Add(weather);
        return weather;
    }

    public void Delete(Guid id)
    {
        var firstOrDefault 
            = _weathers.FirstOrDefault(w => w.Id == id);
        _weathers.Remove(firstOrDefault);
    }
}