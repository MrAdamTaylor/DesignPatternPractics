using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Interpreter
{
    public class InterpreterLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {

            var expressions = new List<RomanExpression>
            {
                new RomanCenterionExpression(),
                new RomanTenExpression(),
                new RomanOneExpression(),
            };

            var context = new RomanContext(5);
            foreach (var expression in expressions)
            {
                expression.Interpret(context);
            }
            Debug.Log($"Перевод арабских чисел. Номер = 5: {context.Output}");
        }
    }
}