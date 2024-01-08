using System;
using JetBrains.Annotations;

namespace Patterns.ChainOfResponsibility
{
    public class DocumentLastModifiedHandler : IHandler<Document>
    {
        [CanBeNull] private IHandler<Document> _successor;

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
            _successor = successor;
            return successor;
        }

        public void Handle(Document document)
        {
            if (document.LastModified < DateTime.UtcNow.AddDays(-30))
            {
                throw new Exception("Документ должен быть изменён в течении последних 30-ти дней");
            }
            _successor?.Handle(document);
        }
    }
}