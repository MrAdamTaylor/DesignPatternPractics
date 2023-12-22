using Adapter.NeedAdaptation;

namespace Adapter.AdapterCore
{
    public interface ICityAdapter
    {
        City GetCity();
    }

    class CityAdapter : ICityAdapter
    {
        public ExternalSystem ExternalSystem { get; private set; } = new();

        public City GetCity()
        {
            var cityFromExternalSystem = ExternalSystem.GetCity();

            string fullNickame = cityFromExternalSystem.Name + " - " + cityFromExternalSystem.NickName;

            return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}",
                cityFromExternalSystem.Inhavitants);
        }
    }
}