using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Core.Data
{
    public interface IUnitOfWork 
    {
        IHumidityRepository HumidityRepository { get; }
        IFlowerRepository FlowerRepository { get; }

        void Commit();
    }
}
