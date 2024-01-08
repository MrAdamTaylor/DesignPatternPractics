namespace Patterns.AdapterComposite.AdaptedObject
{
    public class GraphData
    {
        public bool Undir;
        public int Size;
        public int[] GraphStructure;
        public GraphIntPairs[] Pairs;
        public int ShiftCount { get; set; }


        public GraphData(int count)
        {
            Pairs = new GraphIntPairs[count];
        }

        public GraphData GetData() 
        {
            return this;
        }

        public class GraphIntPairs
        {
            public int GraphPoint;
            public int[] NeighborPoints;
        }
    }
}