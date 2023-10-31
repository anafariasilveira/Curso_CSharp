using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using FashionTrend.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionTrend.Persistence.Repositories
{
    public class SupplierRepository : BaseRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(AppDbContext context) : base (context)
        {
            
        }
        async Task<Supplier> ISupplierRepository.GetTipoMaquina(string tipomaquina, CancellationToken cancellationToken)
        {
            return await Context.Suppliers.FirstOrDefaultAsync(
            x => x.TipoMaquina.Equals(tipomaquina), cancellationToken);
        }

        async Task<Supplier> ISupplierRepository.GetTipoMaterial(string tipomaterial, CancellationToken cancellationToken)
        {
            return await Context.Suppliers.FirstOrDefaultAsync(
            x => x.TipoMaterial.Equals(tipomaterial), cancellationToken);
        }
    }
}
