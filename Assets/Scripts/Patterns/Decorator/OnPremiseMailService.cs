using UnityEngine;

namespace Patterns.Decorator
{
    class OnPremiseMailService : IMailService
    {
        public bool SendMail(string message)
        {
            Debug.Log($"Сообщение {message} отправленно с помощью {nameof(OnPremiseMailService)}");
            return true;
        }
    }
}