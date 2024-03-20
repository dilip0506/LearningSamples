using System;
using System.Runtime.Serialization;

namespace Customexception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserDefineException();
            }
            catch (UserDefineException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
    [Serializable]
    class UserDefineException : Exception
    {
        public UserDefineException() : base()
        {
        }
        public UserDefineException(string message) : base(message)
        {
            Console.WriteLine("logged in");
        }
        public UserDefineException(string message, Exception innerException) : base(message, innerException)
        {

        }
        public UserDefineException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
