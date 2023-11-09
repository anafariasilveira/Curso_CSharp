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
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext Context;
        public BaseRepository(AppDbContext context)
        {
            Context = context;
        }
        void IBaseRepository<T>.Create(T entity)
        {
            entity.DateCreated = DateTimeOffset.Now;
            Context.Add(entity);
        }
        void IBaseRepository<T>.Delete(T entity)
        {
            entity.DateDeleted = DateTimeOffset.Now;
            Context.Remove(entity);
        }
        async Task<T> IBaseRepository<T>.Get(Guid id, CancellationToken cancellationToken)
        {
            return await Context.Set<T>().FirstOrDefaultAsync(
                x => x.Id.Equals(id), cancellationToken);
        }
        async Task<List<T>> IBaseRepository<T>.GetAll(CancellationToken cancellationToken)
        {
            return await Context.Set<T>().ToListAsync(cancellationToken);
        }
        void IBaseRepository<T>.Update(T entity)
        {
            entity.DateUpdated = DateTimeOffset.Now;
            Context.Update(entity);
        }
    }
}
