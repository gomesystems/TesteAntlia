using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDDProject.MVC.Controllers
{
    public class ProdutoCosifController : Controller
    {
        // GET: ProdutoCosif
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProdutoCosif/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProdutoCosif/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutoCosif/Create
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

        // GET: ProdutoCosif/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdutoCosif/Edit/5
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

        // GET: ProdutoCosif/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProdutoCosif/Delete/5
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
