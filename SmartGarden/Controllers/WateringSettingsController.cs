using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartGarden.Core.Dto;
using SmartGarden.Core.Services;

namespace SmartGarden.API.Controllers
{
    public class WateringSettingsController : Controller
    {
        IWateringSettingsService _wateringSettingsService;
        // GET: WateringSettings
        public ActionResult Index()
        {
            return View();
        }

        // GET: WateringSettings/Details/5
        public ActionResult Details(int id)
        {
            var wateringSettings = _wateringSettingsService.GetOne<WateringSettingsDto>(id);
            return View();
        }

        // GET: WateringSettings/Create
        public ActionResult Create()
        {           
            return View();
        }

        // POST: WateringSettings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WateringSettings/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WateringSettings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WateringSettings/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WateringSettings/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}