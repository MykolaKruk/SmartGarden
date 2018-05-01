using AutoMapper;
using SmartGarden.Core.Data;
using SmartGarden.Core.Entities;
using SmartGarden.Core.Services;
using SmartGarden.Services.Base;

namespace SmartGarden.Services
{
    public class WateringSettingsService : BaseService<WateringSettings, IWateringSettingsRepository>, IWateringSettingsService
    {
        protected WateringSettingsService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public bool UpperMinnimumPercentageHumidity(WateringSettings wateringSettings)
        {
            var dbSet = Repository.GetOne(wateringSettings.Id);
            if (wateringSettings.MinHumidity >= dbSet.MinHumidity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override IWateringSettingsRepository InitRepository()
        {
            return UnitOfWork.WateringSettingsRepository;
        }
    }
}
