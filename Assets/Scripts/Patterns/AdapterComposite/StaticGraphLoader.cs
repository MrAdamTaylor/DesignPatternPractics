using System.Collections.Generic;
using EnterpriseLogic.ServiceLocator;
using Patterns.AdapterComposite.AdaptedObject;
using UnityEngine;

namespace Patterns.AdapterComposite
{
    public class StaticGraphLoader
    {
        private readonly ServiceAllocator _serviceAllocator;

        private List<GraphData> _graphData = new List<GraphData>();

        public StaticGraphLoader(ServiceAllocator sevices)
        {
            _serviceAllocator = sevices;
        }

        public void LoadData()
        {
            var loadedData = Resources.LoadAll<GraphStaticData>("StaticData/Graphs/GraphData");
            for (int i = 0; i < loadedData.Length; i++)
            {
                GraphData data = loadedData[i].GetData();
                _graphData.Add(data);
            }
            _serviceAllocator.RegisterSingle<IExternalSystemGraph>(new ExternalSystemGraph(_graphData));
        }

    }
}