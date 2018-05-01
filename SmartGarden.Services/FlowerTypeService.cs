using AutoMapper;
using SmartGarden.Core.Data;
using SmartGarden.Core.Entities;
using SmartGarden.Core.Services;
using SmartGarden.Services.Base;

namespace SmartGarden.Services
{
    public class FlowerTypeService : BaseService<FlowerType, IFlowerTypeRepository>, IFlowerTypeService
    {
        protected FlowerTypeService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        protected override IFlowerTypeRepository InitRepository()
        {
            return UnitOfWork.FlowerTypeRepository;
        }
    }
}
