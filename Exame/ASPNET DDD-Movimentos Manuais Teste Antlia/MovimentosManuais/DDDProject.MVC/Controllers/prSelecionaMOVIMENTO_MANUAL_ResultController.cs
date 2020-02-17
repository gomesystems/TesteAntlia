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
    public class prSelecionaMOVIMENTO_MANUAL_ResultController : Controller
    {
        private Antlia_DBEntities db = new Antlia_DBEntities();

        // GET: prSelecionaMOVIMENTO_MANUAL_Result
        public ActionResult Index()
        {
            return View(db.prSelecionaMOVIMENTO_MANUAL_Result.ToList());
        }

        // GET: prSelecionaMOVIMENTO_MANUAL_Result/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prSelecionaMOVIMENTO_MANUAL_Result prSelecionaMOVIMENTO_MANUAL_Result = db.prSelecionaMOVIMENTO_MANUAL_Result.Find(id);
            if (prSelecionaMOVIMENTO_MANUAL_Result == null)
            {
                return HttpNotFound();
            }
            return View(prSelecionaMOVIMENTO_MANUAL_Result);
        }

        // GET: prSelecionaMOVIMENTO_MANUAL_Result/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: prSelecionaMOVIMENTO_MANUAL_Result/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COD_COSIF,DAT_MES,DAT_ANO,COD_PRODUTO,NUM_LANCAMENTO,DES_DESCRICAO,VAL_VALOR,DAT_MOVIMENTO,COD_USUARIO")] prSelecionaMOVIMENTO_MANUAL_Result prSelecionaMOVIMENTO_MANUAL_Result)
        {
            if (ModelState.IsValid)
            {
                db.prSelecionaMOVIMENTO_MANUAL_Result.Add(prSelecionaMOVIMENTO_MANUAL_Result);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prSelecionaMOVIMENTO_MANUAL_Result);
        }

        // GET: prSelecionaMOVIMENTO_MANUAL_Result/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prSelecionaMOVIMENTO_MANUAL_Result prSelecionaMOVIMENTO_MANUAL_Result = db.prSelecionaMOVIMENTO_MANUAL_Result.Find(id);
            if (prSelecionaMOVIMENTO_MANUAL_Result == null)
            {
                return HttpNotFound();
            }
            return View(prSelecionaMOVIMENTO_MANUAL_Result);
        }

        // POST: prSelecionaMOVIMENTO_MANUAL_Result/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COD_COSIF,DAT_MES,DAT_ANO,COD_PRODUTO,NUM_LANCAMENTO,DES_DESCRICAO,VAL_VALOR,DAT_MOVIMENTO,COD_USUARIO")] prSelecionaMOVIMENTO_MANUAL_Result prSelecionaMOVIMENTO_MANUAL_Result)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prSelecionaMOVIMENTO_MANUAL_Result).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prSelecionaMOVIMENTO_MANUAL_Result);
        }

        // GET: prSelecionaMOVIMENTO_MANUAL_Result/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prSelecionaMOVIMENTO_MANUAL_Result prSelecionaMOVIMENTO_MANUAL_Result = db.prSelecionaMOVIMENTO_MANUAL_Result.Find(id);
            if (prSelecionaMOVIMENTO_MANUAL_Result == null)
            {
                return HttpNotFound();
            }
            return View(prSelecionaMOVIMENTO_MANUAL_Result);
        }

        // POST: prSelecionaMOVIMENTO_MANUAL_Result/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            prSelecionaMOVIMENTO_MANUAL_Result prSelecionaMOVIMENTO_MANUAL_Result = db.prSelecionaMOVIMENTO_MANUAL_Result.Find(id);
            db.prSelecionaMOVIMENTO_MANUAL_Result.Remove(prSelecionaMOVIMENTO_MANUAL_Result);
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
