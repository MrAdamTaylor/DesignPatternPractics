using Patterns.Adapter.AdapterCore;
using UnityEngine;

namespace Patterns.Adapter
{
    public class AdabterLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Adapter запущен");
            ICityAdapter adapter = new CityAdapter();
            var city = adapter.GetCity();
            
            Debug.Log($"{city.FullName}, {city.Inhabitants}");
        }
    }
}