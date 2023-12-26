using FactoryMethod.Auxiliary_elements;

namespace FactoryMethod.Factory_Method_Service
{
    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _code;

        public CodeDiscountService(Guid code)
        {
            _code = code;
        }


        public override int DiscountPercentage
        {
            get => 15;
        }
    }
}