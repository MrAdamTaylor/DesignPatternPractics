using System;
using JetBrains.Annotations;

namespace Patterns.ChainOfResponsibility
{
    public class DocumentApprovedByManagmentHandler : IHandler<Document>
    {
        [CanBeNull] private IHandler<Document> _successor;

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
            _successor = successor;
            return successor;
        }

        public void Handle(Document document)
        {
            if (!document.ApprovedByManagement)
            {
                throw new Exception("Документ должен быть одобрен руководством");
            }
            _successor?.Handle(document);
        }
    }
}