using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Core.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        TDto GetOne<TDto>(int id);
        TDto Create<TDto>(TDto dto) where TDto : class;
        TDto Update<TDto>(TDto dto);
        void Delete(int id);
    }
}
