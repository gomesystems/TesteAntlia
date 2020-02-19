using DDDProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDDProject.MVC.Controllers
{
    public class MovimentosManuaisController : Controller
    {
        // GET: MovimentosManuais
        MovimentosManuaisProc movimentosManuaisProc = new MovimentosManuaisProc();

        public ActionResult Index()
        {   
            //erro
            ///List<MovimentosManuaisProc> lstMov = new List<MovimentosManuaisProc>();
            // lstMov = movimentosManuaisProc.GetAllMovimentosManuaiss().ToList();
            //  return View(lstMov);
            return View();
        }


        // GET: MovimentosManuais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovimentosManuais/Create
        [HttpPost]
        public ActionResult Create([Bind] MovimentosManuaisProc movimentosManuais)
        {
            try
            {
                // TODO:
                // movimentosManuaisProc.AddMovimentosManuais(movimentosManuais);
               // return View();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
