
using UnityEngine;

namespace Patterns.Bridge
{
    public class BridgeLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Запущен паттерн Bridge: ");
            var noCoupon = new NoCoupon();
            var oneErouCoupon = new OneCoupon();

            var meatBasedMenu = new MeatBasedMenu(noCoupon);
            Debug.Log($"Мясное меню с без купона: {meatBasedMenu.CalculatePrice()}");

            meatBasedMenu = new MeatBasedMenu(oneErouCoupon);
            Debug.Log($"Мясное меню с одним купоном: {meatBasedMenu.CalculatePrice()}");

            var vegetarianMenu = new VegetarianMenu(noCoupon);
            Debug.Log($"Вегетерянское меню без купона: {vegetarianMenu.CalculatePrice()}");

            vegetarianMenu = new VegetarianMenu(oneErouCoupon);
            Debug.Log($"Вегетерянское меню с одним купоном: {vegetarianMenu.CalculatePrice()}");
            Debug.Log("");
        }
    }
}
