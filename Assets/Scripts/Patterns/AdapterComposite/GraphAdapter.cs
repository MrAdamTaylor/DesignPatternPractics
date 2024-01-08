using System.Collections.Generic;
using System.Linq;
using EnterpriseLogic.ServiceLocator;
using Patterns.AdapterComposite.AdaptedObject;
using Patterns.AdapterComposite.OutputObject;

namespace Patterns.AdapterComposite
{
    public class GraphAdapter :  IgrapAdapter
    {
        //TODO - это в будущем будет убрано
        public IExternalSystemGraph ExternalSystemGraph { get; set; } =
            ServiceAllocator.Container.Single<IExternalSystemGraph>();

        private IStructGraphDataIntReader _graphDataReader;
        private IStructGraphDataIntWriter _graphDataWriter;

        public StructGraphData GetGraphData()
        {
            GraphData graphExternal = ExternalSystemGraph.GetGraph();
            StructGraphData structGraphData = new StructGraphData(graphExternal.Size);
            _graphDataReader = new StructGraphDataIntReader(structGraphData);
            _graphDataWriter = new StructGraphDataIntWriter(structGraphData);
            ConvertToStruct(graphExternal, structGraphData);
            return structGraphData;
        }

        private void ConvertToStruct(GraphData data, StructGraphData structGraphData)
        {
            bool flag = data.Undir;
            for (int i = 0; i < data.Pairs.Length; i++)
            {
                for (int j = 0; j < data.Pairs[i].NeighborPoints.Length; j++)
                {
                    int graphPoint = data.Pairs[i].GraphPoint;
                    int neighbor = data.Pairs[i].NeighborPoints[j];
                    AddEdge(graphPoint, neighbor, flag, data.Size);
                }
            }

            DeleteDublicates(structGraphData.GraphConections);
        }

        private void DeleteDublicates(List<int>[] graphConections)
        {
            for (int i = 0; i < graphConections.Length; i++)
            {
                graphConections[i] = graphConections[i].Distinct().ToList();
            }
        }


        private void AddEdge(int graphPoint, int neighbor, bool flag=true, int size=0)
        {
            if (size != 0)
            {
                if (_graphDataReader.CheckPointByNull(graphPoint))
                {
                    _graphDataWriter.Add(graphPoint, neighbor);
                }
                else
                {
                    _graphDataWriter.InitEdge(graphPoint);
                    _graphDataWriter.Add(graphPoint, neighbor);
                }

                if (flag)
                {
                    if (_graphDataReader.CheckPointByNull(neighbor))
                    {
                        _graphDataWriter.Add(neighbor, graphPoint);
                    }
                    else
                    {
                        _graphDataWriter.InitEdge(neighbor);
                        _graphDataWriter.Add(neighbor, graphPoint);
                    }
                }
            }
        }
    }
}