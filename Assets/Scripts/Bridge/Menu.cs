

public abstract class Menu
{
    public readonly ICoupon _coupon = null!;
    
    public abstract int CalculatePrice();

    public Menu(ICoupon coupon)
    {
        _coupon = coupon;
    }
}

class MeatBasedMenu : Menu
{
    public MeatBasedMenu(ICoupon coupon) : base(coupon)
    {
    }

    public override int CalculatePrice()
    {
        return 30 - _coupon.CouponValue;
    }
}

class VegetarianMenu : Menu
{
    public VegetarianMenu(ICoupon coupon) : base(coupon)
    {
    }

    public override int CalculatePrice()
    {
        return 20 - _coupon.CouponValue;
    }
}

public interface ICoupon
{
    int CouponValue { get; }
}

class TwoCoupon : ICoupon
{
    public int CouponValue { get => 2; }
}

class OneCoupon : ICoupon
{
    public int CouponValue { get => 1; }
}

class NoCoupon : ICoupon
{
    public int CouponValue { get; }
}
