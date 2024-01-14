namespace Patterns.Interpreter
{
    public class RomanTenExpression : RomanExpression
    {
        public override void Interpret(RomanContext value)
        {
            while ((value.Input - 90) >= 0)
            {
                value.Output += "XC";
                value.Input -= 9;
            }
        
            while ((value.Input - 50) >= 0)
            {
                value.Output += "L";
                value.Input -= 5;
            }
        
            while ((value.Input - 40) >= 0)
            {
                value.Output += "XL";
                value.Input -= 4;
            }
        
            while ((value.Input - 10) >= 0)
            {
                value.Output += "X";
                value.Input -= 9;
            }
        }
    }
}