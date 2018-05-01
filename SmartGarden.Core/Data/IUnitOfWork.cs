using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Core.Data
{
    public interface IUnitOfWork 
    {
        IFlowerRepository FlowerRepository { get; }
        IFlowerTypeRepository FlowerTypeRepository { get; }
        IMeasureUnitRepository MeasureUnitRepository { get; }
        IWateringSettingsRepository WateringSettingsRepository { get; }

        void Commit();
    }
}
