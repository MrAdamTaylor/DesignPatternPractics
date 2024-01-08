using UnityEngine;

namespace Patterns.Decorator
{
    class StatisticsDecorator : MailServiceDecoratorBase
    {
        public StatisticsDecorator(IMailService mailService) : base(mailService)
        {
        
        }

        public override bool SendMail(string message)
        {
            Debug.Log($"Сбор статистики в {nameof(StatisticsDecorator)}.");
            return base.SendMail(message);
        }
    }
}