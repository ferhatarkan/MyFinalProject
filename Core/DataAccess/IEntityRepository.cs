using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Core katmanı diğer katmanları referans almaz.
    //Generic Constraint
    //Class:referans tip
    //new() new edilebilir olmalı
    //IEntity: IEntity olabilir veya Ientity implement eden bir sınıf olabilir
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
