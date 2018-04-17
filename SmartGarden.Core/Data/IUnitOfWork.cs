using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Core.Data
{
    public interface IUnitOfWork 
    {
        IFlowerRepository FlowerRepository { get; }

        void Commit();
    }
}
