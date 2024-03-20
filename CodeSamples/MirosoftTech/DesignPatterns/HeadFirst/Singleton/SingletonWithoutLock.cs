namespace HeadFirst.Singleton
{
    public class SingletonWithoutLock
    {
        //single instance is create with the class initiated no need to worry about threads
        private static readonly SingletonWithoutLock instance = new();
        private SingletonWithoutLock() { }
        public static SingletonWithoutLock GetInstance()
        {
            return instance;
        }
    }
}