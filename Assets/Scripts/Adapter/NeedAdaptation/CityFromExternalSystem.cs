namespace Adapter.NeedAdaptation
{
    public class CityFromExternalSystem 
    {
        public string Name { get; private set; }

        public string NickName { get; private set; }

        public int Inhavitants { get; private set; }

        public CityFromExternalSystem(string name, string nickName, int inhavitants)
        {
            Name = name;
            NickName = nickName;
            Inhavitants = inhavitants;
        }
    }
}
