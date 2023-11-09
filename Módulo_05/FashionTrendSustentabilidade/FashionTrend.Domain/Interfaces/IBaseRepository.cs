﻿using FashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionTrend.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        public void Create(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public Task<T> Get(Guid id, CancellationToken cancellationToken);
        public Task<List<T>> GetAll(CancellationToken cancellationToken);
    }
}
