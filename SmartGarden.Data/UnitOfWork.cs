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
        private IHumidityRepository _humidityRepository;
        private IFlowerRepository _flowerRepository;

        public UnitOfWork()
        {
            _dbContext = new FlowerpotContext();
        }

        public IHumidityRepository HumidityRepository
        {
            get
            {
                if (_humidityRepository == null)
                    _humidityRepository = new HumidityRepository(_dbContext);
                return _humidityRepository;
            }
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
