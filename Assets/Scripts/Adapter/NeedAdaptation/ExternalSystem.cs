namespace Adapter.NeedAdaptation
{
    public class ExternalSystem
    {
        public CityFromExternalSystem GetCity()
        {
            return new CityFromExternalSystem("Antwerp", "'t Stad'", 500000);
        }
    }
}