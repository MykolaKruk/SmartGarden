using AutoMapper;
using SmartGarden.Core.Data;
using SmartGarden.Core.Entities;
using SmartGarden.Core.Services;
using SmartGarden.Services.Base;

namespace SmartGarden.Services
{
    public class MeasureUnitService : BaseService<MeasureUnit, IMeasureUnitRepository>, IMeasureUnitService
    {
        protected MeasureUnitService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        protected override IMeasureUnitRepository InitRepository()
        {
            return UnitOfWork.MeasureUnitRepository;
        }
    }
}
