public class ServiceContract : BaseEntity
{
    public Guid OrderId { get; set; }
    public Guid SupplierId { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public EContractStatus Status { get; set; }
    public ERequestType Type { get; set; }
}