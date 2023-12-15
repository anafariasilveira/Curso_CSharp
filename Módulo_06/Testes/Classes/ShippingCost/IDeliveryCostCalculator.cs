namespace Classes.ShippingCost
{
    public interface IDeliveryCostCalculator
    {
        double CalculateCost(double distance, DeliveryType deliveryType);
    }
}
