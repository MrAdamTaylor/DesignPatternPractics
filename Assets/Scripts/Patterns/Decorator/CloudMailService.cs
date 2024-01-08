using UnityEngine;

namespace Patterns.Decorator
{
    public class CloudMailService : IMailService
    {
        public bool SendMail(string message)
        {
            Debug.Log($"Сообщение {message} отправленно с помощью {nameof(CloudMailService)}");
            return true;
        }
    }
}