using UnityEngine;

namespace AbstractFactory
{
    public class ShoppingCart
    {
        private readonly IDiscountService _discountService;
        private readonly IShippingCostsService _shippingCostsService;
        private int _orderCost;

        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();
            _shippingCostsService = factory.CreateShippingCostsService();
            _orderCost = 200;
        }

        public void CalculateCosts()
        {
            Debug.Log($"Total costs = {(float)_orderCost - (_orderCost/100 * _discountService.DiscountPercentage)+_shippingCostsService.ShippingCosts}");
        }
    }
}