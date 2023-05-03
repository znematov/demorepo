using API.Services;
using NUnit.Framework;

namespace TestProject1.ServicesTests;

public class WeatherForecastStorageTests
{
    [Test]
    public void GetAllWeatherForecastsCountTest()
    {
        //arrange
        var service = new WeatherForecastStorage();

        //act
        var result = service.GetAll();

        //assert
        Assert.AreEqual(5,result.Count);
    }
    
    [Test]
    public void GetAllWeatherForecastsCountIsEmpty()
    {
        //arrange
        var service = new WeatherForecastStorage();

        //act
        var result = service.GetAll();

        //assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void GetAndPostThenGetAllWeatherForecasts()
    {
        //arrange
        var service = new WeatherForecastStorage();

        //act
        var result = service.GetAll();

        //assert
        Assert.IsEmpty(result);
        
        //arrange
        var weather = new CreateWeatherDto()
        {
            Day = 5, Month = 3, Year = 2023, Summary = "Summary"
        };
        
        //act
        service.Post(weather);
        
        //assert
        Assert.AreEqual(1,result.Count);
    }
}