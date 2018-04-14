using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartGarden.Core;
using SmartGarden.Core.Services;

namespace SmartGarden.API.Controllers
{
    [Route("[controller]")]
    public class HumidityController : Controller
    {
        IHumidityService _humidityService;

        public HumidityController(IHumidityService humidityService)
        {
            _humidityService = humidityService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var humidity = _humidityService.GetOne<HumidityDto>(id);

                if (humidity == null)
                    return BadRequest("Humidity not found.");

                return Json(humidity);
            }
            catch (Exception ex)
            {
                return StatusCode(400);
            }
        }

        [HttpGet("GetByFlower")]
        public IActionResult GetByFlower([FromQuery]int flowerId)
        {
            try
            {
                var humidity = _humidityService.GetByFlower(flowerId);

                if (humidity == null)
                    return BadRequest("Humidity not found.");

                return Json(humidity);
            }
            catch (Exception ex)
            {
                return StatusCode(400);
            }
        }
    }
}