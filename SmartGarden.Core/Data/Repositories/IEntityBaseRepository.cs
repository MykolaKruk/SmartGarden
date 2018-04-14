using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Core.Data
{
    public interface IEntityBaseRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity GetOne(int id);
        void Delete(int id);
    }
}
