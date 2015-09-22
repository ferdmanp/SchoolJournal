using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoolJournal.Controllers
{
    public class PupilsController : Controller
    {
        // GET: Pupils
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pupils/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pupils/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pupils/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pupils/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pupils/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pupils/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pupils/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
