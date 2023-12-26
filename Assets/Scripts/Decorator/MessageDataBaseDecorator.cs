using System.Collections.Generic;

namespace Decorator
{
    class MessageDataBaseDecorator : MailServiceDecoratorBase
    {
        public List<string> SentMessage { get; private set; } = new List<string>();

        public MessageDataBaseDecorator(IMailService mailService) : base(mailService)
        {
        
        }

        public override bool SendMail(string message)
        {
            if (base.SendMail(message))
            {
                SentMessage.Add(message);
                return true;
            }

            return false;
        }
    }
}