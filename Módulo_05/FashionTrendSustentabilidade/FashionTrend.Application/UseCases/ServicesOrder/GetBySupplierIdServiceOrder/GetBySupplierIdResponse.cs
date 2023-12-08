public sealed record GetBySupplierIdResponse
{
    public Guid Id { get; set; }
    public Supplier Supplier { get; set; }
    public Service Service { get; set; }
    public DateTimeOffset EstimatedDate { get; set; }
    public EContractStatus Status { get; set; }
    public bool Payment { get; set; }
    public ERequestType Type { get; set; }
}