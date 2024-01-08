using UnityEngine;

namespace Patterns.Observer
{
    public class OrderService : TicketChangeNotify
    {
        public void CompleteTicketSale(int artistId, int amount)
        {
            Debug.Log($"{nameof(OrderService)} изменяет это состояние.");
            Debug.Log($"{nameof(OrderService)} оповещающий обзорвер...");
            Notify(new TicketChange(artistId, amount));
        }
    }
}