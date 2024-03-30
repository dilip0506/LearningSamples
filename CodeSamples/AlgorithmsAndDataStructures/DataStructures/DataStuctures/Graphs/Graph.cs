namespace DataStuctures.Graphs
{
    public class Graph
    {
        public int Vertex { get; set; }
        public HashSet<int> Edges { get; set; } = new HashSet<int>();
    }
}