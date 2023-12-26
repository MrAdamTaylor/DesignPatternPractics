namespace Facade
{
    public class CustomerDiscountBaseService
    {
        public float CalculateDiscountBase(int customId)
        {
            return (customId > 8) ? 10 : 20;
        }
    }
}