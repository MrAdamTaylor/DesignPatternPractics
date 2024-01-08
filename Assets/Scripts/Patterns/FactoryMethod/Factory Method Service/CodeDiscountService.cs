using Patterns.FactoryMethod.Auxiliary_elements;

namespace Patterns.FactoryMethod.Factory_Method_Service
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