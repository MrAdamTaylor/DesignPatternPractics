namespace Patterns.Observer
{
    public interface ITicketChangeListener
    {
        void ReceiveTicketChangeNotification(TicketChange ticketChange);
    }
}