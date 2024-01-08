using UnityEngine;

namespace Patterns.Proxy
{
    public enum UserType
    {
        Viewer,
        Administrator,
        Unknown
    }

    public class ProxyLauncher : DesignPatternLauncher
    {
        public UserType UserType;
        
        public override void Launch()
        {
            #region Не прокси

                
                Debug.Log("Создаём документ.");
                var myDocument = new Document("MyDocument.pdf");
                Debug.Log("Документ сделан");
                myDocument.DisplayDocument();

            #endregion

            #region Прокси
                Debug.Log("Запуск паттерна Прокси: ");
                Debug.Log("Создание Proxy документа");
                var myDocProxy = new DocumentProxy("MyDocument2.pdf");
                Debug.Log("Документ сделан");
                myDocProxy.DisplayDocument();

            #endregion

            #region Ленивая инициализация

                Debug.Log("Запуск паттерна Прокси с использованием Lazy: ");
                Debug.Log("Создание Proxy-Lazy документа");
                var myDocLazy = new DocumentLazy("MyDocument3.pdf");
                Debug.Log("Документ сделан");
                myDocLazy.DisplayDocument();

            #endregion

            #region Защитный пркоси
                
                Debug.Log("Создание защищённого документа прокси.");
                var myProtectedDocumentProxy = new ProtectedDocumentProxy("MyDocument4.pdf",GetUserType(UserType));
                Debug.Log("Защищённый документ прокси сделан");
                myProtectedDocumentProxy.DisplayDocument();
            #endregion
        }

        private string GetUserType(UserType userType)
        {
            switch (userType)
            {
                case UserType.Viewer:
                    return "Viewer";
                case UserType.Administrator:
                    return "Administrator";
                default:
                    return "Unknown";
            }
        }
    }
}