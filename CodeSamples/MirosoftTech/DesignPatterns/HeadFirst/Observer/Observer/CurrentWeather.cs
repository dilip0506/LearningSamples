using HeadFirst.Observer.Subject;
using System;

namespace HeadFirst.Observer.Observer
{
    public class CurrentWeather : IObserver, IDisplayElements
    {

        private decimal Temparature;
        private decimal Humidity;
        private decimal Pressure;
        private static WeatherData _weatherData;

        public CurrentWeather(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
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
            Temparature = _weatherData.Temparature;
            Humidity = _weatherData.Humidity;
            Pressure = _weatherData.Pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"This is Curent Weather \n {Temparature} and {Humidity} and {Pressure}");
        }


    }
}
