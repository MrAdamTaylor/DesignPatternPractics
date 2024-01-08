using System.Collections.Generic;
using Patterns.FactoryMethod.Auxiliary_elements;
using Patterns.FactoryMethod.Factory_Method_Implements;
using UnityEngine;

namespace Patterns.FactoryMethod
{
    public class FactoryMethodLauncher : DesignPatternLauncher
    {

        private List<DiscountFactory> _factories;

        public override void Launch()
        {
            Debug.Log("Паттенр фабричный метод: ");
            InstallFactories();
            CreateDiscounts();
        }

        private void InstallFactories()
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