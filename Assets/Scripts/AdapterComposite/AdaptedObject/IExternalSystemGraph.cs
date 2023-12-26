using EnterpriseLogic.ServiceLocator;

namespace AdapterComposite.AdaptedObject
{
    public interface IExternalSystemGraph : IService
    {
        public GraphData GetGraph();
    }
}