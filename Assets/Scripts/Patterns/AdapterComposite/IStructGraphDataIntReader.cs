using System.Collections.Generic;
using Patterns.AdapterComposite.OutputObject;

namespace Patterns.AdapterComposite
{
    internal interface IStructGraphDataIntReader
    {
        bool CheckPointByNull(int index);
        List<int> GetNeighboursByIndex(int first);
        int GetShift();
    }

    class StructGraphDataIntReader : IStructGraphDataIntReader
    {
        private StructGraphData _data;

        public StructGraphDataIntReader(StructGraphData data)
        {
            _data = data;
        }
        
        public bool CheckPointByNull(int index)
        {
            int newIndex = index - _data.shiftValue;
            if (_data.GraphConections[newIndex] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<int> GetNeighboursByIndex(int first)
        {
            int newIndex = first - _data.shiftValue;
            return _data.GraphConections[newIndex];
        }

        public int GetShift()
        {
            return _data.shiftValue;
        }
    }
}