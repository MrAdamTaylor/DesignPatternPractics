using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethod
{
    public class FactoryMethodLauncher : DesignPatternLauncher
    {

        private List<DiscountFactory> _factories;

        public override void Launch()
        {
            IntallFactories();
            CreateDiscounts();
        }

        private void IntallFactories()
        {
            _factories = new List<DiscountFactory>
            {
                new CodeDiscountFactory(Guid.NewGuid()),
                new CountryDiscountFactory("BE")
            };
        }

        private void CreateDiscounts()
        {
            foreach (var factory in _factories)
            {
                var discountService = factory.CreateDiscountService();
                Debug.Log($"Percantage {discountService.DiscountPercentage}" 
                + $"coming from {discountService}");
            }
        }
    }
}