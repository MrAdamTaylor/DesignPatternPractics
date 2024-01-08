using Patterns.FactoryMethod.Auxiliary_elements;
using Patterns.FactoryMethod.Factory_Method_Service;

namespace Patterns.FactoryMethod.Factory_Method_Implements
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