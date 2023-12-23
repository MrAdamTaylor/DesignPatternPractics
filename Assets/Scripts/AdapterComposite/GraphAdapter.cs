using AdapterComposite.AdaptedObject;
using EnterpriseLogic.ServiceLocator;
using UnityEngine;

namespace AdapterComposite
{
    public class GraphAdapter : IgrapAdapter
    {
        //TODO - это в будущем будет убрано
        public IExternalSystemGraph ExternalSystemGraph { get; set; } =
            ServiceAllocator.Container.Single<IExternalSystemGraph>();

        public StructGraphData GetGraphData()
        {
            
            GraphData graphExternal = ExternalSystemGraph.GetGraph();
            Debug.Log("Содержимое GraphData, который надо адаптировать!");
            Debug.Log($"{graphExternal.GraphStructure}");
            Debug.Log($"{graphExternal.Size}");
            Debug.Log($"{graphExternal.Undir}");
            StructGraphData structGraphData = new StructGraphData(1);
            Debug.Log("Была создана пустышка");
            return structGraphData;
        }
    }
}