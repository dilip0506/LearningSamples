using HeadFirst.Observer.Observer;
using HeadFirst.Observer.Subject;

namespace HeadFirst.Observer
{
    public static class WeatherStation
    {
        public static void Run()
        {

            var weatherData = new WeatherData();
            _ = new CurrentWeather(weatherData);
            _ = new StaticWeather(weatherData);

            weatherData.SetMeasurements(20.0m, 60.2m, 45.5m);
            weatherData.SetMeasurements(28.0m, 68.2m, 25.5m);
        }
    }
}
