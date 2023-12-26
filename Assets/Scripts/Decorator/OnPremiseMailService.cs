using UnityEngine;

namespace Decorator
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