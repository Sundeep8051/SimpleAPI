using Microsoft.Extensions.Logging;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();
    [Fact]
    public void GetReturnsMyName(){
        var returnValue = controller.Get();
        Assert.Equal("Freezi", returnValue);
    }


    [Fact]
    public void Test1()
    {

    }
}