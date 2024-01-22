using Patterns.Adapter.NeedAdaptation;

namespace Patterns.Adapter.AdapterCore
{
    class CityAdapter : ICityAdapter
    {
        public ExternalSystem ExternalSystem { get; private set; } = new();

        public City GetCity()
        {
            var cityFromExternalSystem = ExternalSystem.GetCity();

            string fullNickame = cityFromExternalSystem.Name + " - " + cityFromExternalSystem.NickName;

            return new City($"{fullNickame}",
                cityFromExternalSystem.Inhavitants);
        }
    }
}