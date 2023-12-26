using FactoryMethod.Auxiliary_elements;
using FactoryMethod.Factory_Method_Service;

namespace FactoryMethod.Factory_Method_Implements
{
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _code;

        public CodeDiscountFactory(Guid code)
        {
            _code = code;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_code);
        }
    }
}