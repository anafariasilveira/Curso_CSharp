public sealed record GetByTypeResponse
{
    //public Guid SupplierId { get; set; }
    public Guid ServiceId { get; set; }
   // public DateTimeOffset EstimatedDate { get; set; }
    public ERequestType Type { get; set; }
}