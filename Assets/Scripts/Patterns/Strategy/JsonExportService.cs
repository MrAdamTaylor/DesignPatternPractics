using UnityEngine;

namespace Patterns.Strategy
{
    public class JsonExportService : IExportService
    {
        public void Export(Order order)
        {
            Debug.Log($"Экспортирование заказа {order.Name} в JSON");
        }
    }
}