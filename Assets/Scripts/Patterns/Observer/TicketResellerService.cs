using UnityEngine;

namespace Patterns.Observer
{
    public class TicketResellerService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange ticketChange)
        {
            Debug.Log($"{nameof(TicketResellerService)} notified " 
                      + $"of ticket change: artist {ticketChange.ArtistId}, amount " 
                      + $"{ticketChange.Amount}");
        }
    }
}