namespace HeadFirst.Singleton
{
    public class Singleton
    {
        private static Singleton? instance;
        private Singleton() { }
        /*
        This not thread safe.
        However all Thread will access the same static instance(line 5).
        On the creation of first instance two threads calling same function
        the If condition fail(object not be created by first call instance will null) and will return two instances
        Other classes in this project have alternative implementation which are thread safe
        consider finding diff between static and sigleton
        */
        public static Singleton GetInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}