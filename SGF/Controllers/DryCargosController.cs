using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGF.Controllers
{
    public class DryCargosController : Controller
    {
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
