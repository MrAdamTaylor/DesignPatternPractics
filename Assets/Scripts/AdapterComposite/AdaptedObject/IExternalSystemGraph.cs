using AdapterComposite.AdaptedObject;
using EnterpriseLogic.ServiceLocator;

namespace AdapterComposite
{
    public interface IExternalSystemGraph : IService
    {
        public GraphData GetGraph();
    }
}