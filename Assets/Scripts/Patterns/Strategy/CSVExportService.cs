using UnityEngine;

namespace Patterns.Strategy
{
    public class CSVExportService : IExportService
    {
        public void Export(Order order)
        {
            Debug.Log($"Экспортирование заказа {order.Name} в CSV");
        }
    }
}