using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatchTheDeceiver.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatchTheDeceiver.Controllers
{
    public class DecieverController : Controller
    {
        // GET: Deciever
        public ActionResult Index()
        {
            return View();
        }

        // GET: Deciever/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Deciever/Create
        public ActionResult Create(PotentialDeciever model)
        {
            return View();
        }

        // POST: Deciever/Create
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

        // GET: Deciever/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Deciever/Edit/5
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

        // GET: Deciever/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Deciever/Delete/5
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