using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace classconstructure
{
    class Program
    {
        public static string name;
        int _i;
        int _j;
        static Program() {//no need of instatilating object//called first
            Program.name = "dilip";
            Console.WriteLine(name);
        }
        public Program() : this(0, 0)//if object is instantiated without parameters this constructer invokes and passes default values to next custructor
        {
            //this._i = 0;
            //this._j = 0;
        }
        //public Program(int i = 0, int j = 0){can also do this
        public Program(int i, int j){
                this._i = i;
                this._j = j;
                Console.WriteLine("numbers {0} and {1}", _i, _j);
        }

        static void Main(string[] args)
        {
            //Program pnon = new Program();
            //Program p = new Program();
            Console.Read();
        }
    }
    class Program2 {

        public static void main() {
            Console.WriteLine(Program.name);
            //Program p = new Program();
            //Program p1 = new Program(2,3);
        }
    }
}
