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
    public class FlowerTypeController : Controller
    {
        IFlowerTypeService _flowerTypeService;
        // GET: FlowerType
        public ActionResult Index()
        {
            return View();
        }

        // GET: FlowerType/Details/5
        public ActionResult Details(int id)
        {
            var flowerType = _flowerTypeService.GetOne<FlowerTypeAndWateringSettingsDto>(id);

            return View();
        }

        // GET: FlowerType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FlowerType/Create
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

        // GET: FlowerType/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FlowerType/Edit/5
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

        // GET: FlowerType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FlowerType/Delete/5
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