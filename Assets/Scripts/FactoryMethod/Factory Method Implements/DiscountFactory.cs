using FactoryMethod.Factory_Method_Service;

namespace FactoryMethod.Factory_Method_Implements
{
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }
}