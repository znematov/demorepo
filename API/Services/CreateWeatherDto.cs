namespace API.Services;

public class CreateWeatherDto
{
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }
    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}