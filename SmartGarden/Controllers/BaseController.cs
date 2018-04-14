using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartGarden.Core.Entities.Abstract;

namespace SmartGarden.API.Controllers
{
    public class BaseController<TEntity> : Controller where TEntity : class, IEntity
    {
    }
}