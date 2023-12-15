namespace Classes.CartDiscount
{
    public interface IDiscountService
    {
        double CalculateDiscount(List<CartItem> items);
    }
}
