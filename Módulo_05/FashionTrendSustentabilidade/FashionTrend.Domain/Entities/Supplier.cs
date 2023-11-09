using FashionTrend.Domain.Enums;
using System.ComponentModel.DataAnnotations;


namespace FashionTrend.Domain.Entities
{
    public class Supplier : BaseEntity
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<EMaterial> Materials { get; set; }
        public List<ESewingMachine> SewingMachines { get; set; }

        /*public List<EMaterial> Materials { get; set; }
        public List<ESewingMachine> SewingMachines { get; set; }*/
    }
}
