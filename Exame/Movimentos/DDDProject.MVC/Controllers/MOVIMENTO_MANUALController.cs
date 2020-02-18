using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DDDProject.MVC;

namespace DDDProject.MVC.Controllers
{
    public class MOVIMENTO_MANUALController : Controller
    {
        private Antlia_DBEntities db = new Antlia_DBEntities();

        // GET: MOVIMENTO_MANUAL
        public ActionResult Index()
        {
            var mOVIMENTO_MANUAL = db.MOVIMENTO_MANUAL.Include(m => m.PRODUTO_COSIF);
            return View(mOVIMENTO_MANUAL.ToList());
        }

        // GET: MOVIMENTO_MANUAL/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOVIMENTO_MANUAL mOVIMENTO_MANUAL = db.MOVIMENTO_MANUAL.Find(id);
            if (mOVIMENTO_MANUAL == null)
            {
                return HttpNotFound();
            }
            return View(mOVIMENTO_MANUAL);
        }

        // GET: MOVIMENTO_MANUAL/Create
        public ActionResult Create()
        {
            ViewBag.COD_PRODUTO = new SelectList(db.PRODUTO_COSIF, "COD_PRODUTO", "COD_CLASSIFICACAO");
            return View();
        }

        // POST: MOVIMENTO_MANUAL/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COD_PRODUTO,COD_COSIF,DAT_ANO,DAT_MES,NUM_LANCAMENTO,VAL_VALOR,DES_DESCRICAO,DAT_MOVIMENTO,COD_USUARIO")] MOVIMENTO_MANUAL mOVIMENTO_MANUAL)
        {
            if (ModelState.IsValid)
            {
                db.MOVIMENTO_MANUAL.Add(mOVIMENTO_MANUAL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.COD_PRODUTO = new SelectList(db.PRODUTO_COSIF, "COD_PRODUTO", "COD_CLASSIFICACAO", mOVIMENTO_MANUAL.COD_PRODUTO);
            return View(mOVIMENTO_MANUAL);
        }

        // GET: MOVIMENTO_MANUAL/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOVIMENTO_MANUAL mOVIMENTO_MANUAL = db.MOVIMENTO_MANUAL.Find(id);
            if (mOVIMENTO_MANUAL == null)
            {
                return HttpNotFound();
            }
            ViewBag.COD_PRODUTO = new SelectList(db.PRODUTO_COSIF, "COD_PRODUTO", "COD_CLASSIFICACAO", mOVIMENTO_MANUAL.COD_PRODUTO);
            return View(mOVIMENTO_MANUAL);
        }

        // POST: MOVIMENTO_MANUAL/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COD_PRODUTO,COD_COSIF,DAT_ANO,DAT_MES,NUM_LANCAMENTO,VAL_VALOR,DES_DESCRICAO,DAT_MOVIMENTO,COD_USUARIO")] MOVIMENTO_MANUAL mOVIMENTO_MANUAL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mOVIMENTO_MANUAL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.COD_PRODUTO = new SelectList(db.PRODUTO_COSIF, "COD_PRODUTO", "COD_CLASSIFICACAO", mOVIMENTO_MANUAL.COD_PRODUTO);
            return View(mOVIMENTO_MANUAL);
        }

        // GET: MOVIMENTO_MANUAL/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOVIMENTO_MANUAL mOVIMENTO_MANUAL = db.MOVIMENTO_MANUAL.Find(id);
            if (mOVIMENTO_MANUAL == null)
            {
                return HttpNotFound();
            }
            return View(mOVIMENTO_MANUAL);
        }

        // POST: MOVIMENTO_MANUAL/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MOVIMENTO_MANUAL mOVIMENTO_MANUAL = db.MOVIMENTO_MANUAL.Find(id);
            db.MOVIMENTO_MANUAL.Remove(mOVIMENTO_MANUAL);
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
