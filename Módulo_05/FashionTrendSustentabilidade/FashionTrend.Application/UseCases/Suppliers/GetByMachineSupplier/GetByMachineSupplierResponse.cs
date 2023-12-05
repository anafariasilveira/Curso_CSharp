public sealed record GetByMachineSupplierResponse
{
    public Guid Id { get; set; }
    //public string? Name { get; set; }
    //public string? Email { get; set; }
    //public List<EMaterial>? Materials { get; set; }
    public ESewingMachine SewingMachines { get; set; }
}