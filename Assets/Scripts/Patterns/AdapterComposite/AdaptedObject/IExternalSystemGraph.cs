using EnterpriseLogic.ServiceLocator;

namespace Patterns.AdapterComposite.AdaptedObject
{
    public interface IExternalSystemGraph : IService
    {
        public GraphData GetGraph();
    }
}