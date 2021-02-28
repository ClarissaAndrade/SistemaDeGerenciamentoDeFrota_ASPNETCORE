using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGF.Models;
using SGF.Models.ViewModels;
using SGF.Services;
using SGF.Services.Exceptions;

namespace SGF.Controllers
{
    public class DryCargosController : Controller
    {

        private readonly DryCargoService _dryCargoService;
        private readonly CityService _cityService;
        private readonly StateService _stateService;

        public DryCargosController(DryCargoService dryCargoService, CityService cityService, StateService stateService)
        {
            _dryCargoService = dryCargoService;
            _cityService = cityService;
            _stateService = stateService;
        }

        // GET: DryCargosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DryCargosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DryCargosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DryCargosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DryCargosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DryCargosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DryCargosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DryCargosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
