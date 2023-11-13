﻿public class Service : BaseEntity
{
    public string Description { get; set; }
    public bool Delivery { get; set; }
    public List<ERequestType> Type { get; set; }
    public List<ESewingMachine> SewingMachines { get; set; }
    public List<EMaterial> Materials { get; set; }
}