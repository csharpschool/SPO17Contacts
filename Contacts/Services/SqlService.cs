using Contacts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Services
{
    public class SqlService : ISqlService
    {
        public ContactDbContext _db { get; set; }

        public SqlService(ContactDbContext db)
        {
            _db = db;
        }

        public IQueryable<TEntity> Get<TEntity>() where TEntity : class
        {
            return _db.Set<TEntity>();
        }

        public void Add<TEntity>(TEntity item) where TEntity : class
        {
            _db.Add(item);
            _db.SaveChanges();
        }

        public void Update<TEntity>(TEntity item) where TEntity : class
        {
            _db.Update(item);
            _db.SaveChanges();
        }

        public void Delete<TEntity>(TEntity item) where TEntity : class
        {
            _db.Remove(item);
            _db.SaveChanges();
        }
    }
}
