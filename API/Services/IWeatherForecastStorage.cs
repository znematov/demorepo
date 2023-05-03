namespace API.Services;

public interface IWeatherForecastStorage
{
    List<WeatherForecast> GetAll();
    void Post(CreateWeatherDto newWeather);
    WeatherForecast Put(Guid id, CreateWeatherDto updatedWeather);
    void Delete(Guid id);
}