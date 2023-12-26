using JetBrains.Annotations;

namespace Proxy
{
    class DocumentProxy : IDocument
    {
        [CanBeNull] private Document _document;
        private string _fileName;

        public DocumentProxy(string fileName)
        {
            _fileName = fileName;
        }

        public void DisplayDocument()
        {
            if (_document == null)
            {
                _document = new Document(_fileName);
            }
            _document.DisplayDocument();
        }
    }
}