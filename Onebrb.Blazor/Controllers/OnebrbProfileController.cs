using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Onebrb.Blazor.Controllers
{
    public class OnebrbProfileController : Controller
    {
        // GET: OnebrbProfile
        public ActionResult Index()
        {
            return View();
        }

        // GET: OnebrbProfile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OnebrbProfile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OnebrbProfile/Create
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

        // GET: OnebrbProfile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OnebrbProfile/Edit/5
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

        // GET: OnebrbProfile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OnebrbProfile/Delete/5
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