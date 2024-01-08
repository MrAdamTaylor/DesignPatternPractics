using UnityEngine;

namespace Patterns.Template_Methods
{
    public class ExchangeMailParser : MailParser
    {
        public override void AuthenticateToServer()
        {
            Debug.Log("Подключение к Exchange: ");
        }
    }
}