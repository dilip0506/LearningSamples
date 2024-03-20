using System;
using System.IO;

namespace Exceptionhandling
{
    class Program
    {
        /*exception handing example
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader SR = new StreamReader(@"D:\Practice\dotnet\exin.txt"))
                {
                    Console.WriteLine(SR.ReadToEnd());
                }
            }
            //write exception in order
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("file not found {0}", ex.FileName);
                //log to database
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);//stacktrace gives complete exception
            }
            catch (DirectoryNotFoundException)
            {//can or cannot have variable object is to access methods
                Console.WriteLine("dir not found");
            }
            catch (Exception)
            {
                Console.WriteLine("unhandled excetion");
            }
            finally {
                //using keyword above terminates the streamreader if using is not used close the streamreader here
                //we can also write without finally but excution may stops somewhere. finally exectutes at any cost
            }
            Console.ReadKey();
        }
        exmaple end here*/
        //inner exception 
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("enter first");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter second");
                    int j = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("resultfsd is {0}", i / j);
                }
                //write exception in order
                catch (Exception ex)
                {
                    Console.WriteLine("somthing went wrong! contact admin");
                    string path = @"D:\Practice\dotnet\exout.txt";
                    if (File.Exists(path))
                    {
                        using (StreamWriter SR = new StreamWriter(path))
                        {
                            SR.Write(ex.GetType().Name);
                            SR.WriteLine();
                            SR.Write(ex.Message);
                            SR.Write(ex.StackTrace);
                        }
                    }
                    else
                    {
                        throw new FileNotFoundException("file not fount", ex);//throws inner exception and current exception
                    }

                }
            }
            catch (Exception exex)
            {
                Console.WriteLine("inner exception: {0} \nouter exception: {1}",exex.InnerException.GetType().Name,exex.GetType().Name);
            }
            finally
            {
                //using keyword above terminates the streamreader if using is not used close the streamreader here
                //we can also write without finally but excution may stops somewhere. finally exectutes at any cost
            }
            Console.ReadKey();
        } 
    }
}
