using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDDProject.MVC.Controllers
{
    public class ProcMovimentosController : Controller
    {
        // GET: ProcMovimentos
        public ActionResult Index()
        {
            return View();
        }


        // GET: ProcMovimentos/Create
        public ActionResult Create()
        {
            try
            {
                // TODO: configurar
                //prSelecionaMOVIMENTO_MANUAL_Result db = new prSelecionaMOVIMENTO_MANUAL_Result();
                //SqlParameter param1 = new SqlParameter("@COD_PRODUTO", COD_PRODUTO);
                //SqlParameter param2 = new SqlParameter("@COD_COSIF", COD_COSIF);
                //SqlParameter param3 = new SqlParameter("@NUM_LANCAMENTO", NUM_LANCAMENTO);
                //// var data = db.Database.SqlQuery("exec prSelecionaMOVIMENTO_MANUAL_Result @COD_PRODUTO ,@COD_COSIF,@NUM_LANCAMENTO ", param1, param2, param3).SingleOrDefault();
                /////continuar ....
                /////
                ////return View(data);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // POST: ProcMovimentos/Create
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

        
        }
    }

