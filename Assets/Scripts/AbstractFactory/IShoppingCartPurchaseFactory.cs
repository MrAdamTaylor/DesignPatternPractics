namespace AbstractFactory
{
    
        public interface IShoppingCartPurchaseFactory
        {
            IDiscountService CreateDiscountService();

            IShippingCostsService CreateShippingCostsService();
        }
}