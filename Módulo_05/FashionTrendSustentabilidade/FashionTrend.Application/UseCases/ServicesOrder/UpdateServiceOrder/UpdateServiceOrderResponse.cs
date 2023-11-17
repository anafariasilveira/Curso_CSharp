public sealed record UpdateServiceOrderResponse
{
    public Guid SupplierId { get; set; }
    public Guid ServiceId { get; set; }
    public DateTimeOffset EstimatedDate { get; set; }
    public EContractStatus Status { get; set; }
}