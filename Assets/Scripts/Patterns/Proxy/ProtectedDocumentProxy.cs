using System.ComponentModel;
using UnityEngine;

namespace Patterns.Proxy
{
    class ProtectedDocumentProxy : IDocument
    {
        private string _fileName;
        private string _userRole;
        private DocumentProxy _documentProxy;

        public ProtectedDocumentProxy(string fileName, string userRole)
        {
            _fileName = fileName;
            _userRole = userRole;
            _documentProxy = new DocumentProxy(_fileName);
        }

        public void DisplayDocument()
        {
            Debug.Log($"Вывод дисплей документа: in {nameof(ProtectedDocumentProxy)}");

            if (_userRole != "Viewer" && _userRole != "Administrator")
            {
                throw new WarningException("Такой пользователь не имеет права доступа");
            }
            _documentProxy.DisplayDocument();
            
            Debug.Log($"Cуществующий дисплэй-документ: {nameof(ProtectedDocumentProxy)}");
        }
    }
}