using UnityEngine;

namespace Patterns.Observer
{
    public class TicketStockService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange ticketChange)
        {
            Debug.Log($"{nameof(TicketStockService)} ");
        }
    }
}