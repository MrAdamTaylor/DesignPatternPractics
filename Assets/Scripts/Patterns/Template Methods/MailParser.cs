using UnityEngine;

namespace Patterns.Template_Methods
{
    public abstract class MailParser
    {
        public virtual void FindServer()
        {
            Debug.Log("Найти сервер...");
        }

        public abstract void AuthenticateToServer();

        public string ParseHtmlMailBody(string identificator)
        {
            Debug.Log("Parsing HTML BODY...");
            return $"Это тело mail с id " + identificator;
        }

        public string ParseMailBody(string identifier)
        {
            Debug.Log("Парсинг mail тела в шаблоне");
            FindServer();
            AuthenticateToServer();
            return ParseHtmlMailBody(identifier);
        }
    }
}