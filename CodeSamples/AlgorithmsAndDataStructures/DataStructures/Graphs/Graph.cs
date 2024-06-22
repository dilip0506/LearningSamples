namespace DataStuctures.Graphs
{
    public class Graph
    {
        public int Vertex { get; set; }
        public List<int>[] Edges { get; set; }  = new List<int>[2];

        public void AddEdge(int v, int e){
            Edges[v].Add(e);
        }

        public static void Run(){
            var graph = new Graph();
            graph.AddEdge(0,2);
            Console.WriteLine("HI");
        } 
    }
}