using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        public string Location { get; private set; }
        public double Temperature { get; private set; }

        private const int COLD_THRESHOLD_TEMPERATURE = 10;
        private const int HOT_THRESHOLD_TEMPERATURE = 30;

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
            return $"I am in {Location} and it is {CheckLocation()}. {GetTemperatureDescription()}. The temperature in Fahrenheit is {this.ConvertToFahrenheit()}.";
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

        public string GetTemperatureDescription()
        {
            if (Temperature > HOT_THRESHOLD_TEMPERATURE)
            {

                return "It's too hot!";

            }
            else if (Temperature < COLD_THRESHOLD_TEMPERATURE)
            {

                return "It's too cold!";

            }
            return "Ahhh...it's just right!";
        }

    }
}

