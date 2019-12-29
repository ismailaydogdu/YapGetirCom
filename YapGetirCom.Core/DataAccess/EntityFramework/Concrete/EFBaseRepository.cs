using System;
using YapGetirCom.Core.DataAccess.EntityFramework.Abstract;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;


namespace YapGetirCom.Core.DataAccess.EntityFramework
{
    public class EFRepositoryBase<TEntity> : IEFBaseRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        protected DbContext _db;
        public EFRepositoryBase(DbContext db)
        {
            _db = db;
        }
        public void Add(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Added;
            _db.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Deleted;
            _db.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }
        public TEntity GetById(int id)
        {
            return _db.Set<TEntity>().Find(id);
           
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _db.Set<TEntity>().Where(filter).SingleOrDefault();
            
        }
        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                return _db.Set<TEntity>().ToList();
            }
            else
            {
                return _db.Set<TEntity>().Where(filter).ToList();
            }

        }
    }
}
