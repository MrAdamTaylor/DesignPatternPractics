using UnityEngine;

namespace Patterns.Decorator
{
    public class DecoratorLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Запущен паттерн декоратор!");
            var cloudMailService = new CloudMailService();
            cloudMailService.SendMail("Hi there.");

            var onPremiseMailService = new OnPremiseMailService();
            onPremiseMailService.SendMail("Hi there");

            var statisticsDecorator = new StatisticsDecorator(cloudMailService);
            statisticsDecorator.SendMail($"Привет всем. (Отправлено при помощи {nameof(StatisticsDecorator)})");

            var messageDatabaseDecorator = new MessageDataBaseDecorator(onPremiseMailService);
            messageDatabaseDecorator.SendMail(
                $"Привет всем: (Отправлено при помощи {nameof(MessageDataBaseDecorator)}), сообщение 1");
            messageDatabaseDecorator.SendMail(
                $"Привет всем: (Отправлено при помощи {nameof(MessageDataBaseDecorator)}), сообщение 2");

            foreach (var message in messageDatabaseDecorator.SentMessage)
            {
                Debug.Log($"Отправленные сообщения: {message}");
            }
        }
    }
}