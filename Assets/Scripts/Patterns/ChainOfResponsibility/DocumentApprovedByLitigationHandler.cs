using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Patterns.ChainOfResponsibility
{
    public class DocumentApprovedByLitigationHandler : IHandler<Document>
    {
        [CanBeNull] private IHandler<Document> _successor;

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
            _successor = successor;
            return successor;
        }

        public void Handle(Document document)
        {
            if (!document.ApprovedByLitigation)
            {
                Debug.LogWarning("Документ должен быть утверждён в судебном порядке");
            }
            _successor?.Handle(document);
        }
    }
}