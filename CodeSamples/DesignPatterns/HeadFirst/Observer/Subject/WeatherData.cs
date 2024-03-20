using HeadFirst.Observer.Observer;
using System.Collections.Generic;

namespace HeadFirst.Observer.Subject
{
    public class WeatherData : ISubject
    {
        private readonly IList<IObserver> Observers;
        public decimal Temparature { get; set; }
        public decimal Humidity;
        public decimal Pressure;

        public WeatherData()
        {
            Observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver ob)
        {
            Observers.Add(ob);
        }

        public void RemoveObserver(IObserver ob)
        {
            Observers.Remove(ob);
        }

        //public void NotifyObserver()
        //{
        //    foreach (var observer in Observers) {
        //        observer.Update(Temparature, Humidity, Pressure);
        //    }
        //}

        public void NotifyObserver()
        {
            foreach (var observer in Observers)
            {
                observer.Update();
            }
        }

        private void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(decimal temparature, decimal humidity, decimal pressure)
        {
            Temparature = temparature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
