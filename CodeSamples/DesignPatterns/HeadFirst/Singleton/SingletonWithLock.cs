namespace HeadFirst.Singleton
{
    public class SingletonWithLock
    {
        private static SingletonWithLock? instance;
        private static readonly object locker = new();
        private SingletonWithLock() { }

        //will lock each thread not preferred if you application is highly mutithreaded
        public static SingletonWithLock GetInstance()
        {
            lock (locker)
            {
                if (instance == null)
                    instance = new SingletonWithLock();
                return instance;
            }
        }

        /*
         Beat of All, will only lock the thread for the first instance and thread safe
         */
        public static SingletonWithLock GetInstanceWIthDoubleCheck()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                        instance = new SingletonWithLock();
                }
            }
            return instance;
        }
    }
}