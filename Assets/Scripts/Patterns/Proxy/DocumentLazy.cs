using System;

namespace Patterns.Proxy
{
    class DocumentLazy : IDocument
    {
        private Lazy<Document> _document;
        private string _fileName;

        public DocumentLazy(string fileName)
        {
            _fileName = fileName;
            _document = new Lazy<Document>(() => new Document(_fileName));
        }

        public void DisplayDocument()
        {
            _document.Value.DisplayDocument();
        }
    }
}