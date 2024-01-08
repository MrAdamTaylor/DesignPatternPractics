using UnityEngine;

namespace Patterns.Strategy
{
    public class StrategyLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Паттерн стратегия: ");
            var order = new Order("Marvis Software", 5, "Visual Studio License");

            order.ExportService = new CSVExportService();
            order.Exort();

            order.ExportService = new JsonExportService();
            order.Exort();
        
        }
    }
}