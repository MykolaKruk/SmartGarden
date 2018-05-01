using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartGarden.Core;
using SmartGarden.Core.Services;

namespace SmartGarden.API.Controllers
{
    public class FlowerController : Controller
    {
        IFlowerService _flowerService;
        // GET: Flower
        public ActionResult Index()
        {
            return View();
        }

        // GET: Flower/Details/5
        public ActionResult Details(int id)
        {
            var flower = _flowerService.GetOne<FlowerDto>(id);
            return View();
        }

        // GET: Flower/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Flower/Create
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

        // GET: Flower/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Flower/Edit/5
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

        // GET: Flower/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Flower/Delete/5
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