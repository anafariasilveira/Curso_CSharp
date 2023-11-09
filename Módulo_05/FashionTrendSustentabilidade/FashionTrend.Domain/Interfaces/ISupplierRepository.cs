using FashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionTrend.Domain.Interfaces
{
    public interface ISupplierRepository : IBaseRepository<Supplier>
    {
        public Task<Supplier> GetByEmail(string email, CancellationToken cancellationToken);
        public Task<List<Supplier>> GetByMaterials(string material, CancellationToken cancellationToken);
        public Task<List<Supplier>> GetByMachine(string sewingmachine, CancellationToken cancellationToken);

        // public Task<Supplier> GetByMaterials(string material, CancellationToken cancellationToken);
    }
}
