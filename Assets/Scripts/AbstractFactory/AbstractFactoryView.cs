namespace AbstractFactory
{
    
        public interface IShoppingCartPurchaseFactory
        {
            IDiscountService CreateDiscountService();

            IShippingCostsService CreateShippingCostsService();
        }

        public class ShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
        {
            public IDiscountService CreateDiscountService()
            {
                return new FranceDiscountService();
            }

            public IShippingCostsService CreateShippingCostsService()
            {
                return new FranceShippingCostsService();
            }
        }
        public class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
        {
            public IDiscountService CreateDiscountService()
            {
                return new BelgiumDiscountService();
            }

            public IShippingCostsService CreateShippingCostsService()
            {
                return new BelgiumShippingCostsService();
            }
        }

        public interface IDiscountService
        {
            int DiscountPercentage { get; }
        }

        class FranceDiscountService : IDiscountService
        {
            public int DiscountPercentage => 10;
        }

        class BelgiumDiscountService : IDiscountService
        {
            public int DiscountPercentage => 20;
        }

        public interface IShippingCostsService
        {
            float ShippingCosts { get; }
        }

        class FranceShippingCostsService : IShippingCostsService
        {
            public float ShippingCosts => 25;
        }

        class BelgiumShippingCostsService : IShippingCostsService
        {
            public float ShippingCosts => 20;
        }
}