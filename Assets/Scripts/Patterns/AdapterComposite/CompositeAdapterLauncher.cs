using EnterpriseLogic.GraphEnterprice;
using EnterpriseLogic.ServiceLocator;
using UnityEngine;

namespace Patterns.AdapterComposite
{
    public class CompositeAdapterLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Adapter из реальной практики запущен");
            StaticGraphLoader loader = new StaticGraphLoader(ServiceAllocator.Container);
            loader.LoadData();
            IgrapAdapter adapter = new GraphAdapter();
            var graphStruct = adapter.GetGraphData();
            graphStruct.OutputGraphsConnections();
            Debug.Log("");
        }
    }
}