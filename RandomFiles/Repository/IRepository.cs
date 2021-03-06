﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RandomFiles.Repository
{
    interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void AddAll(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);        
        void RemoveAll(IEnumerable<TEntity> entities);
    }
}
