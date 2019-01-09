using Contacts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Services
{
    public interface ISqlService
    {
        IQueryable<TEntity> Get<TEntity>() where TEntity : class;
        void Add<TEntity>(TEntity item) where TEntity : class;
        void Update<TEntity>(TEntity item) where TEntity : class;
        void Delete<TEntity>(TEntity item) where TEntity : class;
    }
}
