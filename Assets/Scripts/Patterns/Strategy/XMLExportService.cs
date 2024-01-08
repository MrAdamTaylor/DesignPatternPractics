using UnityEngine;

namespace Patterns.Strategy
{
    public class XMLExportService : IExportService
    {
        public void Export(Order order)
        {
            Debug.Log($"Экспортирование заказа {order.Name} в XML");
        }
    }
}