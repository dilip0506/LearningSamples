using HeadFirst.Observer.Observer;

namespace HeadFirst.Observer.Subject
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver ob);

        public void RemoveObserver(IObserver ob);

        public void NotifyObserver();
    }
}
