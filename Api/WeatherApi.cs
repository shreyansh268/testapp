using System;

namespace testapp.Api
{
    public static class WeatherApi
    {
        /// <summary>
        /// Get temperature from open weather api
        /// </summary>
        /// <param name="cityName">City name</param>
        /// <returns>Numerical value of current celcius temperature</returns>
        public static decimal GetTemperature(string cityName)
        {
            var client = new OpenWeatherAPI.OpenWeatherApiClient("7fe67bf08c80ded756e598d6f8fedaea");
            var response = client.Query(cityName);
            return Convert.ToDecimal(response.Main.Temperature.CelsiusCurrent);
        }
    }
}