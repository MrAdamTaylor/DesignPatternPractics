using UnityEngine;

namespace Patterns.AbstractFactory
{
    public class AbstractFactoryLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Метод абстрактной фабрики");
            CreateFactories();
        }

        private void CreateFactories()
        {
            Debug.Log("Belgium Purchase");
            var belgiumShoppingCardPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();
            var shopingCardForBelgium = new ShoppingCart(belgiumShoppingCardPurchaseFactory);
            shopingCardForBelgium.CalculateCosts();

            Debug.Log("France Purchase");
            var franceShoppingCardPurchaseFactory = new ShoppingCartPurchaseFactory();
            var shopingCardForFrance = new ShoppingCart(franceShoppingCardPurchaseFactory);
            shopingCardForFrance.CalculateCosts();
        }
    }
}