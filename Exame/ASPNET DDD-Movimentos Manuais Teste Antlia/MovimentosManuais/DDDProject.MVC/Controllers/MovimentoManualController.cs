using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovimentosManuais.MVC.Controllers
{
    public class MovimentoManualController : Controller
    {
        // GET: MovimentoManual
        public ActionResult Index()
        {
            return View();
        }

        // GET: MovimentoManual/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovimentoManual/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovimentoManual/Create
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

        // GET: MovimentoManual/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovimentoManual/Edit/5
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

        // GET: MovimentoManual/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovimentoManual/Delete/5
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
