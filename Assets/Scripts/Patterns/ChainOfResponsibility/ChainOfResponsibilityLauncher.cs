using System;
using UnityEngine;

namespace Patterns.ChainOfResponsibility
{
    public class ChainOfResponsibilityLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Pattern: Chain Responsibility");

            var validDocument = new Document("Как избежать работы грузчиком", 
                DateTimeOffset.UtcNow, true, true);
            var invalidDocument = new Document("Как избежать работы грузчиком", 
                DateTimeOffset.UtcNow, false, true);

            var documentHandlerChain = new DoccumentTitleHandler();
            documentHandlerChain
                .SetSuccessor(new DocumentLastModifiedHandler())
                .SetSuccessor(new DocumentApprovedByLitigationHandler())
                .SetSuccessor(new DocumentApprovedByManagmentHandler());

            try
            {
                documentHandlerChain.Handle(validDocument);
                Debug.Log("Верный документ допустим");
                documentHandlerChain.Handle(invalidDocument);
                Debug.Log("Верный документ недопустим!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}