using AdapterComposite.OutputObject;

namespace AdapterComposite
{
    internal interface IStructGraphDataIntWriter
    {
        void Add(int graphValue1, int graphValue2);
        void InitEdge(int i);
        bool CheckClone(int index, int i1);
    }

    class StructGraphDataIntWriter : IStructGraphDataIntWriter
    {
        private StructGraphData _data;

        public StructGraphDataIntWriter(StructGraphData structGraphData)
        {
            _data = structGraphData;
        }
        public void Add(int graphValue1, int graphValue2)
        {
            _data.Add(graphValue1, graphValue2);
        }

        public void InitEdge(int index)
        {
            int newIndex = index - _data.shiftValue;
            _data.InitEdge(newIndex);
        }

        public bool CheckClone(int index, int value)
        {
            int newIndex = index - _data.shiftValue;
            for (int j = 0; j < _data.GraphConections[newIndex].Count; j++)
            {
                if (_data.GraphConections[newIndex][j] == value)
                    return true;
            }

            return false;
        }
    }
}