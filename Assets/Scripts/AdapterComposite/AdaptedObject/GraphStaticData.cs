using EnterpriseLogic;
using EnterpriseLogic.GraphEnterprice;
using UnityEngine;

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

        public GraphData GetData()
        {
            GraphData graphData = new GraphData(GraphData.Length);
            graphData.Undir = undirectGraph;
            int[] dataArray = GraphData.ConvertToArray();
            graphData.Size = graphData.Size.ReturnSizeUniqueNumbers(dataArray);
            graphData.GraphStructure = graphData.GraphStructure.ReturnUniqueArrayNumbers(dataArray);
            graphData.ShiftCount = graphData.GetShiftValue(graphData.GraphStructure);
            for (int i = 0; i < GraphData.Length; i++)
            {
                graphData.Pairs[i] = CreatePairData();
                graphData.Pairs[i].GraphPoint = this.GraphData[i].graph;
                graphData.Pairs[i].NeighborPoints = this.GraphData[i].neighbours;
            }
            return graphData;
        }

        private GraphData.GraphIntPairs CreatePairData()
        {
            GraphData.GraphIntPairs pair = new GraphData.GraphIntPairs();
            return pair;
        }
    }

    [System.Serializable]
    public struct AdjacenyListStruct
    {
        public int graph;
        public int[] neighbours;
    }
}