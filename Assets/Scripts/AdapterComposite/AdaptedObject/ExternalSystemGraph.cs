using System.Collections.Generic;
using AdapterComposite.AdaptedObject;

namespace AdapterComposite
{
    public class ExternalSystemGraph : IExternalSystemGraph
    {
        public ExternalSystemGraph()
        {
            
        }

        private List<GraphData> _graphDatas;

        public ExternalSystemGraph(List<GraphData> graphDatas)
        {
            _graphDatas = graphDatas;
        }

        public GraphData GetGraph()
        {
            var graph = GetFirstGraph();
            return graph;
        }

        private GraphData GetFirstGraph()
        {
            return _graphDatas[0];
        }
    }
}