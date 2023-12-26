using FactoryMethod.Factory_Method_Service;

namespace FactoryMethod.Factory_Method_Implements
{
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _country;

        public CountryDiscountFactory(string country)
        {
            _country = country;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_country);
        }
    }
}