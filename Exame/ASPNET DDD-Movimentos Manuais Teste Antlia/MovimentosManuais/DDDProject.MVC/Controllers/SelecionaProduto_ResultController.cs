using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovimentosManuaisTeste.Models;

namespace MovimentosManuaisTeste.Controllers
{
    public class SelecionaProduto_ResultController : Controller
    {
        private Antlia_DBEntities db = new Antlia_DBEntities();

        // GET: SelecionaProduto_Result
        public ActionResult Index()
        {
            return View(db.SelecionaProduto_Result.ToList());
        }

        // GET: SelecionaProduto_Result/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SelecionaProduto_Result selecionaProduto_Result = db.SelecionaProduto_Result.Find(id);
            if (selecionaProduto_Result == null)
            {
                return HttpNotFound();
            }
            return View(selecionaProduto_Result);
        }

        // GET: SelecionaProduto_Result/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SelecionaProduto_Result/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COD_PRODUTO,DES_PRODUTO,STA_STATUS")] SelecionaProduto_Result selecionaProduto_Result)
        {
            if (ModelState.IsValid)
            {
                db.SelecionaProduto_Result.Add(selecionaProduto_Result);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(selecionaProduto_Result);
        }

        // GET: SelecionaProduto_Result/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SelecionaProduto_Result selecionaProduto_Result = db.SelecionaProduto_Result.Find(id);
            if (selecionaProduto_Result == null)
            {
                return HttpNotFound();
            }
            return View(selecionaProduto_Result);
        }

        // POST: SelecionaProduto_Result/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COD_PRODUTO,DES_PRODUTO,STA_STATUS")] SelecionaProduto_Result selecionaProduto_Result)
        {
            if (ModelState.IsValid)
            {
                db.Entry(selecionaProduto_Result).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(selecionaProduto_Result);
        }

        // GET: SelecionaProduto_Result/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SelecionaProduto_Result selecionaProduto_Result = db.SelecionaProduto_Result.Find(id);
            if (selecionaProduto_Result == null)
            {
                return HttpNotFound();
            }
            return View(selecionaProduto_Result);
        }

        // POST: SelecionaProduto_Result/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SelecionaProduto_Result selecionaProduto_Result = db.SelecionaProduto_Result.Find(id);
            db.SelecionaProduto_Result.Remove(selecionaProduto_Result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
