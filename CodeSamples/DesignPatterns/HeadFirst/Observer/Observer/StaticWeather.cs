using HeadFirst.Observer.Subject;
using System;

namespace HeadFirst.Observer.Observer
{
    public class StaticWeather : IObserver, IDisplayElements
    {
        private decimal Temparature;
        private decimal Humidity;
        private decimal Pressure;
        private static WeatherData _WeatherData;

        public StaticWeather(WeatherData WeatherData)
        {
            _WeatherData = WeatherData;
            _WeatherData.RegisterObserver(this);
        }

        //public void Update(decimal temparature, decimal humidity, decimal pressure)
        //{
        //    this.Temparature = temparature;
        //    this.Humidity = humidity;
        //    this.Pressure = pressure;
        //    Display();
        //}

        public void Update()
        {
            Temparature = _WeatherData.Temparature;
            Humidity = _WeatherData.Humidity;
            Pressure = _WeatherData.Pressure;
            Display();
        }
        public void Display()
        {
            Console.WriteLine($"This is Static Weather \n {Temparature} and {Humidity} and {Pressure}");
        }
    }
}
