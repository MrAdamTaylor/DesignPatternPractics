using UnityEngine;

namespace Patterns.Template_Methods
{
    public class TemplateMethodLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Шаблонный метод");

            ExchangeMailParser exchangeMailParser = new();
            Debug.Log(exchangeMailParser.ParseMailBody("Ef98"));
            Debug.Log("");
        
            ApacheMailParser apacheMailParser = new();
            Debug.Log(apacheMailParser.ParseMailBody("GD3f"));
            Debug.Log("");

            EudoraMailParser eudoraMailParser = new();
            Debug.Log(eudoraMailParser.ParseMailBody("Z8Lm"));
            Debug.Log("");
        }
    }
}