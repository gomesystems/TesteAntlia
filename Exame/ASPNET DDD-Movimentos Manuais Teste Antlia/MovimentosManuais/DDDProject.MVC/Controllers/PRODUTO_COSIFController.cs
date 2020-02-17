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
    public class PRODUTO_COSIFController : Controller
    {
        private Antlia_DBEntities db = new Antlia_DBEntities();

        // GET: PRODUTO_COSIF
        public ActionResult Index()
        {
            var pRODUTO_COSIF = db.PRODUTO_COSIF.Include(p => p.Produto);
            return View(pRODUTO_COSIF.ToList());
        }

        // GET: PRODUTO_COSIF/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUTO_COSIF pRODUTO_COSIF = db.PRODUTO_COSIF.Find(id);
            if (pRODUTO_COSIF == null)
            {
                return HttpNotFound();
            }
            return View(pRODUTO_COSIF);
        }

        // GET: PRODUTO_COSIF/Create
        public ActionResult Create()
        {
            ViewBag.COD_PRODUTO = new SelectList(db.Produto, "COD_PRODUTO", "DES_PRODUTO");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COD_PRODUTO,COD_COSIF,COD_CLASSIFICACAO,STA_STATUS")] PRODUTO_COSIF pRODUTO_COSIF)
        {
            if (ModelState.IsValid)
            {
                db.PRODUTO_COSIF.Add(pRODUTO_COSIF);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.COD_PRODUTO = new SelectList(db.Produto, "COD_PRODUTO", "DES_PRODUTO", pRODUTO_COSIF.COD_PRODUTO);
            return View(pRODUTO_COSIF);
        }

        // GET: PRODUTO_COSIF/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUTO_COSIF pRODUTO_COSIF = db.PRODUTO_COSIF.Find(id);
            if (pRODUTO_COSIF == null)
            {
                return HttpNotFound();
            }
            ViewBag.COD_PRODUTO = new SelectList(db.Produto, "COD_PRODUTO", "DES_PRODUTO", pRODUTO_COSIF.COD_PRODUTO);
            return View(pRODUTO_COSIF);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COD_PRODUTO,COD_COSIF,COD_CLASSIFICACAO,STA_STATUS")] PRODUTO_COSIF pRODUTO_COSIF)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRODUTO_COSIF).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.COD_PRODUTO = new SelectList(db.Produto, "COD_PRODUTO", "DES_PRODUTO", pRODUTO_COSIF.COD_PRODUTO);
            return View(pRODUTO_COSIF);
        }

        // GET: PRODUTO_COSIF/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUTO_COSIF pRODUTO_COSIF = db.PRODUTO_COSIF.Find(id);
            if (pRODUTO_COSIF == null)
            {
                return HttpNotFound();
            }
            return View(pRODUTO_COSIF);
        }

        // POST: PRODUTO_COSIF/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PRODUTO_COSIF pRODUTO_COSIF = db.PRODUTO_COSIF.Find(id);
            db.PRODUTO_COSIF.Remove(pRODUTO_COSIF);
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
