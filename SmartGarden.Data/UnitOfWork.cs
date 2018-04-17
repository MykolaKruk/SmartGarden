using SmartGarden.Core.Data;
using SmartGarden.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private FlowerpotContext _dbContext;
        private IFlowerRepository _flowerRepository;

        public UnitOfWork(FlowerpotContext context)
        {
            _dbContext = context;
        }

        public IFlowerRepository FlowerRepository
        {
            get
            {
                if (_flowerRepository == null)
                    _flowerRepository = new FlowerRepository(_dbContext);
                return _flowerRepository;
            }
        }

        public void Commit() =>
            _dbContext.SaveChanges();
    }
}
