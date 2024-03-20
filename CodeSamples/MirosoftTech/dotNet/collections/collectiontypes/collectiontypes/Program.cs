using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectiontypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Collect c = new Collect();
            Dictionary<int, Collect> DC = new Dictionary<int, Collect>();
            DC.Add(c.Id, c);
            //Collect d = DC[1]//to get value with key "1" is key
            //d.Name
            foreach (KeyValuePair<int, Collect> KeyVal in DC) {
                //foreach (var k in DC.Keys) {
                //foreach (var k in DC.Values) {
                //key = KeyVal.key
                //val = KeyVal.Value
                //name = val.Name
            }
            List<Collect> L = new List<Collect>();
            L.Add(new Collect { Id = 1, Name = "gi", Phone = 111 });//also hva AddRange() GetRange() methods read documentation
            foreach (Collect i in L) {
                int j = i.Id;
            }
            //to compare or sort complex type(here collection class) use IComparable<T> intergave

            Queue<Collect> Q = new Queue<Collect>();//enqueue(),dequeue,peek() can aslo loop foreach,contains()
            Stack<Collect> S = new Stack<Collect>();//push(),pop(),peek() can aslo loop foreach, contains()
        }
    }
    class Collect : IComparable<Collect> {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int CompareTo(Collect other)
        {
            //write logic here (this.id > other.Id) 
            throw new NotImplementedException();
        }
    }
}
