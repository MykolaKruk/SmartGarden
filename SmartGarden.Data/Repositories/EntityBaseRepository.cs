using Microsoft.EntityFrameworkCore;
using SmartGarden.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Data.Repositories
{
    internal class EntityBaseRepository<TEntity> : IEntityBaseRepository<TEntity> where TEntity : class
    {
        protected FlowerpotContext _entities;
        protected readonly DbSet<TEntity> _dbSet;

        public EntityBaseRepository(FlowerpotContext context)
        {
            _entities = context;
            _dbSet = context.Set<TEntity>();
        }

        public TEntity Create(TEntity entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public void Delete(int id)
        {
            TEntity entity = _dbSet.Find(id);
            if(entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public TEntity GetOne(int id)
        {
            return _dbSet.Find(id);
        }

        public TEntity Update(TEntity entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;

            return entity;
        }
    }
}
