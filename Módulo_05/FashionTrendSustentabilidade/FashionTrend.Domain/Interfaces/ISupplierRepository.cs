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
        public Task<Supplier> GetTipoMaquina(string tipomaquina, CancellationToken cancellationToken);
        public Task<Supplier> GetTipoMaterial(string tipomaterial, CancellationToken cancellationToken);
    }
}
