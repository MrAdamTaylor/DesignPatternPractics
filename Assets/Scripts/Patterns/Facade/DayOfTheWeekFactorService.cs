using System;

namespace Patterns.Facade
{
    public class DayOfTheWeekFactorService
    {
        public float CalculateDayOfTheWeekFactor()
        {
            switch (DateTime.UtcNow.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return 0.8f;
                default:
                    return 1.2f;
            }
        }
    }
}