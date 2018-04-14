using AutoMapper;
using SmartGarden.Core.Data;
using SmartGarden.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Services.Base
{
    public abstract class BaseService<TEntity, TRepository> : IService<TEntity> where TEntity : class where TRepository : IEntityBaseRepository<TEntity>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly TRepository _repository;

        protected BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = InitRepository();
        }


        protected IMapper Mapper => _mapper;
        protected IUnitOfWork UnitOfWork => _unitOfWork;
        protected virtual TRepository Repository => _repository;

        protected abstract TRepository InitRepository();

        public virtual TDto Create<TDto>(TDto dto) where TDto : class
        {
            var entity = _mapper.Map<TDto, TEntity>(dto);

            var createdEntity = Repository.Create(entity);
            _unitOfWork.Commit();

            return _mapper.Map<TEntity, TDto>(createdEntity);
        }

        public virtual void Delete(int id)
        {
            Repository.Delete(id);
            _unitOfWork.Commit();
        }

        public virtual TDto GetOne<TDto>(int id)
        {
            var entity = Repository.GetOne(id);
            return _mapper.Map<TEntity, TDto>(entity);
        }

        public virtual TDto Update<TDto>(TDto dto)
        {
            var entity = _mapper.Map<TDto, TEntity>(dto);

            var updatedEntity = Repository.Update(entity);
            _unitOfWork.Commit();

            return _mapper.Map<TEntity, TDto>(updatedEntity);
        }
    }
}
