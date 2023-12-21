namespace FactoryMethod
{
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }
}