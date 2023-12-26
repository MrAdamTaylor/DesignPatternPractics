using UnityEngine;

namespace Facade
{
    public class FacadeLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Паттерн Фасад запущен: ");
            var facade = new DiscountFacade();
            Debug.Log($"Процент скидки для покупателя с id1 {facade.CalculateDiscountPercentage(1)}");
            Debug.Log($"Процент скидки для покупателя с id10 {facade.CalculateDiscountPercentage(10)}");
        }
    }
}