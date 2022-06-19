using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using System.Linq.Expressions;
using System.Linq;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity , TContext>:IEntityRepository<TEntity>
        where TEntity: class , IEntity , new()
        where TContext: DbContext , new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext()) //using ile daha performanslı bir kod 
            {
                var addedEntity = context.Entry(entity); //referansı yakala
                addedEntity.State = EntityState.Added; //o aslında ekelenecek bir nesne
                context.SaveChanges(); //değişiklikleri kaydet 
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext()) //using ile daha performanslı bir kod 
            {
                var deletedEntity = context.Entry(entity); //referansı yakala
                deletedEntity.State = EntityState.Deleted; //o aslında silinecek bir nesne
                context.SaveChanges(); //değişiklikleri kaydet 
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext()) //using ile daha performanslı bir kod 
            {
                var updateEntity = context.Entry(entity); //referansı yakala
                updateEntity.State = EntityState.Modified; //o aslında güncellenecek bir nesne
                context.SaveChanges(); //değişiklikleri kaydet 
            }
        }
    }
}
