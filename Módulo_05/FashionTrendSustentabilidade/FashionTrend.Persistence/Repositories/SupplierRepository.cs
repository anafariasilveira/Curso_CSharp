using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Enums;
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

        public async Task<Supplier> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.Suppliers.FirstOrDefaultAsync(
            x => x.Email.Equals(email), cancellationToken);
        }
        public async Task<List<Supplier>> GetByMachine(string sewingmachine, CancellationToken cancellationToken)
        {
            return await Context.Suppliers.Where(
            x => x.SewingMachines.Any(s => s.Equals(sewingmachine))).ToListAsync(cancellationToken);
        }
        public async Task<List<Supplier>> GetByMaterials(string material, CancellationToken cancellationToken)
        {
            return await Context.Suppliers.Where(
            x => x.Materials.Any(s => s.Equals(material))).ToListAsync(cancellationToken);
        }
    }
}
