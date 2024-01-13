using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Patterns.ChainOfResponsibility
{
    public class DoccumentTitleHandler : IHandler<Document>
    {
        [CanBeNull] private IHandler<Document> _successor;
    
        public void Handle(Document document)
        {
            if (document.Title == string.Empty)
            {
                Debug.LogWarning("Название должно быть заполненно: ");
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