using UnityEngine;

namespace Patterns.Template_Methods
{
    public class ApacheMailParser : MailParser
    {
        public override void AuthenticateToServer()
        {
            Debug.Log("Подключение к Apache: ");
        }
    }
}