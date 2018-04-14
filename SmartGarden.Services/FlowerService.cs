using AutoMapper;
using SmartGarden.Core.Data;
using SmartGarden.Core.Entities;
using SmartGarden.Core.Services;
using SmartGarden.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Services
{
    public class FlowerService : BaseService<Flower, IFlowerRepository>, IFlowerService
    {
        protected FlowerService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        protected override IFlowerRepository InitRepository()
        {
            return UnitOfWork.FlowerRepository;
        }
    }
}
