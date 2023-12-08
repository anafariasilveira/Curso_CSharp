public class ServiceOrder : BaseEntity
{
    public Supplier Supplier { get; set; }
    public Service Service { get; set; }
    public DateTimeOffset EstimatedDate { get; set; }
    public EContractStatus Status { get; set; } = EContractStatus.Pending;
    public bool Payment { get; set; } = false;
    public ERequestType Type { get; set; }
}