using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        public string Location { get; set; }
        public double Temperature { get; set; }

        public WeatherReporter(string location, double temperature)
        {
            Location = location;
            Temperature = temperature;
        }

        public double ConvertToFahrenheit()
        {
            return (9.0 / 5.0) * Temperature + 32;
        }

        public string GetWeatherInfo()
        {
            return $"I am in {Location} and it is {CheckLocation()}. {CheckTemperature()}. The temperature in Fahrenheit is {this.ConvertToFahrenheit()}.";
        }

        public string CheckLocation()
        {
            if (Location == "London")
            {

                return "🌦";

            }
            else if (Location == "California")
            {

                return "🌅";

            }
            else if (Location == "Cape Town")
            {

                return "🌤";

            }
            return "🔆";
        }

        public string CheckTemperature()
        {
            if (Temperature > 30)
            {

                return "It's too hot!";

            }
            else if (Temperature < 10)
            {

                return "It's too cold!";

            }
            return "Ahhh...it's just right!";
        }

    }
}

