using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passbyrefandval
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //int a = 5;
            //int b = a;
            //b = 6;
            //Console.WriteLine("{0},{1}", a, b);

            int j = 0;
            p.reff(ref j);//passby refrence passes refrence to the below method print 100 both points to same location
            Console.WriteLine("pass by refernce,{0}", j);//print 100
            int l = 0;
            p.valu(l);//pass by value sends only value to method i.e 0 l will remain zero in the below method creats new mwmory space(address) for k
            Console.WriteLine("pass by value,{0}", l);//prints 0
            //output parameter method call
            int sum = 0;
            int product = 0;
            p.outpar(5, 6, out sum, out product);
            Console.WriteLine("Sum = {0} and Product = {1}", sum, product);
            //int[] i = new int[10];
            int[] k = { 1, 2, 3, 4 };
            //p.arrparams(k);//with params keyword or without params keyword
            p.arrparams(1, 2, 3, 4, 5);// possible only with params keyword
            Console.Read();
        }
        //refrence parameter method
        public void reff (ref int i){
            i = 100;
        }
        //value parameter method
        public void valu(int k) {
            k = 100;
        }
        //output parameter method(if you want method to return more the one value)
        public void outpar(int x, int y, out int sum, out int product) {
            sum = x + y;
            product = x + y;
        }
        public void arrparams(params int[] i){//params make passing array optional we can also write without params keyword but we must array see implemetation in main method
            //public void arrparams(string[] s, params int[] i) {//possible
            Console.WriteLine("array lenght {0}", i.Length);
            foreach (int j in i) {
                Console.WriteLine(j);
            }
        }
    }
    /*
     make methods default and optional
    hi (int i, int j){
     hi(1,2,null)//this is for optinal parameter
     hi(1,K:"hi")// default
    }
    hi (int i, int j, params int[]){
    
    }
    hi(int i, int j=10, string k){
    }
     */

}
