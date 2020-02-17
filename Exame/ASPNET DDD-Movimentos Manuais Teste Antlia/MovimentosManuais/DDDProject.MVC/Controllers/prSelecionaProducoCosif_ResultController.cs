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
    public class prSelecionaProducoCosif_ResultController : Controller
    {
        private Antlia_DBEntities db = new Antlia_DBEntities();

        // GET: prSelecionaProducoCosif_Result
        public ActionResult Index()
        {
            return View(db.prSelecionaProducoCosif_Result.ToList());
        }

        // GET: prSelecionaProducoCosif_Result/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prSelecionaProducoCosif_Result prSelecionaProducoCosif_Result = db.prSelecionaProducoCosif_Result.Find(id);
            if (prSelecionaProducoCosif_Result == null)
            {
                return HttpNotFound();
            }
            return View(prSelecionaProducoCosif_Result);
        }

        // GET: prSelecionaProducoCosif_Result/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: prSelecionaProducoCosif_Result/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COD_PRODUTO,COD_COSIF,COD_CLASSIFICACAO,STA_STATUS")] prSelecionaProducoCosif_Result prSelecionaProducoCosif_Result)
        {
            if (ModelState.IsValid)
            {
                db.prSelecionaProducoCosif_Result.Add(prSelecionaProducoCosif_Result);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prSelecionaProducoCosif_Result);
        }

        // GET: prSelecionaProducoCosif_Result/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prSelecionaProducoCosif_Result prSelecionaProducoCosif_Result = db.prSelecionaProducoCosif_Result.Find(id);
            if (prSelecionaProducoCosif_Result == null)
            {
                return HttpNotFound();
            }
            return View(prSelecionaProducoCosif_Result);
        }

        // POST: prSelecionaProducoCosif_Result/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COD_PRODUTO,COD_COSIF,COD_CLASSIFICACAO,STA_STATUS")] prSelecionaProducoCosif_Result prSelecionaProducoCosif_Result)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prSelecionaProducoCosif_Result).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prSelecionaProducoCosif_Result);
        }

        // GET: prSelecionaProducoCosif_Result/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prSelecionaProducoCosif_Result prSelecionaProducoCosif_Result = db.prSelecionaProducoCosif_Result.Find(id);
            if (prSelecionaProducoCosif_Result == null)
            {
                return HttpNotFound();
            }
            return View(prSelecionaProducoCosif_Result);
        }

        // POST: prSelecionaProducoCosif_Result/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            prSelecionaProducoCosif_Result prSelecionaProducoCosif_Result = db.prSelecionaProducoCosif_Result.Find(id);
            db.prSelecionaProducoCosif_Result.Remove(prSelecionaProducoCosif_Result);
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
