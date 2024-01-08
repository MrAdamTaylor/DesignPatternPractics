namespace Patterns.FactoryMethod.Factory_Method_Service
{
    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryIdentifier;

        public CountryDiscountService(string countryIdentifier)
        {
            this._countryIdentifier = countryIdentifier; 
        }

        public override int DiscountPercentage
        {
            get
            {
                switch (_countryIdentifier)
                {
                    case "BE":
                        return 20;
                    default:
                        return 10;
                }
            }
        }
    }
}