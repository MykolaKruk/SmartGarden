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
        private IFlowerTypeRepository _flowerTypeRepository;
        private IMeasureUnitRepository _measureUnitRepository;
        private IWateringSettingsRepository _wateringSettingsRepository;

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

        public IFlowerTypeRepository FlowerTypeRepository
        {
            get
            {
                if (_flowerTypeRepository == null)
                    _flowerTypeRepository = new FlowerTypeRepository(_dbContext);
                return _flowerTypeRepository;
            }
        }

        public IMeasureUnitRepository MeasureUnitRepository
        {
            get
            {
                if (_measureUnitRepository == null)
                    _measureUnitRepository = new MeasureUnitRepository(_dbContext);
                return _measureUnitRepository;
            }
        }
        public IWateringSettingsRepository WateringSettingsRepository
        {
            get
            {
                if (_wateringSettingsRepository == null)
                    _wateringSettingsRepository = new WateringSettingsRepository(_dbContext);
                return _wateringSettingsRepository;
            }
        }
        public void Commit() =>
            _dbContext.SaveChanges();
    }
}
