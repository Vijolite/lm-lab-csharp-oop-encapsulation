using Encapsulation.Models;
using FluentAssertions;

namespace Encapsulation.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestConvertToFareigeit()
        {
            var weatherRep = new WeatherReporter("London", 32);
            var farenheit = weatherRep.ConvertToFahrenheit();
            double expectedResult = 89.6;
            farenheit.Should().Be(expectedResult);
        }

        [TestMethod]
        public void TestCheckTemperatureHot()
        {
            var weatherRep = new WeatherReporter("London", 32);
            weatherRep.CheckTemperature().Should().Be("It's too hot!");
        }

        [TestMethod]
        public void TestCheckTemperatureCold()
        {
            var weatherRep = new WeatherReporter("London", 0);
            weatherRep.CheckTemperature().Should().Be("It's too cold!");
        }
    }
}
