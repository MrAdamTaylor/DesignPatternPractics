using UnityEngine;

namespace Patterns.Observer
{
    public class ObserverLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Pattern: Observer");

            TicketStockService ticketStockService = new();
            TicketResellerService ticketResellerService = new();
            OrderService orderService = new();
        
            orderService.AddObserver(ticketStockService);
            orderService.AddObserver(ticketResellerService);
        
            orderService.CompleteTicketSale(1,2);
        
            Debug.Log("");
            orderService.RemoveObserver(ticketResellerService);
        
            orderService.CompleteTicketSale(2, 4);
            Debug.Log("");
        }
    }
}