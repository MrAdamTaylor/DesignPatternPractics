using System.Collections.Generic;

namespace AdapterComposite.OutputObject
{
    public class StructGraphData 
    {
        private int GraphSize;
        public List<int>[] GraphConections;
        public int shiftValue;

        public StructGraphData(int dataSize)
        {
            GraphConections = new List<int>[dataSize];
            GraphSize = dataSize;
        }

        public void Add(int graphIndex, int graphValue)
        {
            int newIndex = graphIndex - shiftValue;
            GraphConections[newIndex].Add(graphValue);
        }
    
        public void InitEdge(int index)
        {
            GraphConections[index] = new List<int>();
        }
    }
}
