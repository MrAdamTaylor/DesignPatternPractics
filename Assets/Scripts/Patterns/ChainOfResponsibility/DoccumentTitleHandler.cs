using System;
using JetBrains.Annotations;

namespace Patterns.ChainOfResponsibility
{
    public class DoccumentTitleHandler : IHandler<Document>
    {
        [CanBeNull] private IHandler<Document> _successor;
    
        public void Handle(Document document)
        {
            if (document.Title == string.Empty)
            {
                throw new Exception("Название должно быть заполненно: ");
            }
            _successor?.Handle(document);
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
            _successor = successor;
            return successor;
        }
    }
}