using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class:referans tip
    //IEntity: IEntity olabilir veya onu ıplemete eden bir nesne olabilir 
    //new : new lwnwbilir olmalı 
    public interface IEntityRepository<T> 
        where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);  //Expression : filtre vermemizi sağlar
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
