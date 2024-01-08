using UnityEngine;

namespace Patterns.Template_Methods
{
    public class EudoraMailParser : MailParser
    {
        public override void FindServer()
        {
            Debug.Log("Поиск Eudora server через другой алгоритм...");
        }

        public override void AuthenticateToServer()
        {
            Debug.Log("Подключение к Eudora: ");
        }
    }
}