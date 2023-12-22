using UnityEngine;
using Object = System.Object;

namespace AdapterComposite.AdaptedObject
{
    [CreateAssetMenu(
        fileName = "GraphData",
        menuName = "App/GraphData"
    )]
    public class GraphStaticData : ScriptableObject
    {
        public bool undirectGraph = true;
        public AdjacenyListStruct[] GraphData;
    }
    
    [System.Serializable]
    public struct AdjacenyListStruct
    {
        public int graph;
        public int[] neighbours;
    }
    

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